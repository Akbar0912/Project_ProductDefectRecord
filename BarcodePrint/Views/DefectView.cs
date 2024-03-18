using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodePrint.Views
{
    public partial class DefectView : Form, IDefectView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public DefectView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage2);
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //search
            btnClose.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            textSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            //Add New
            btnAdd.Click += delegate
            {
                AddEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Add new Defect";
            };
            //Delete
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Yakin untuk menghapus", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            //save
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);
                }
                MessageBox.Show(Message);
            };
            //cancle
            btnCancle.Click += delegate
            {
                CancleEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
            };
            //edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit Defect name";
            };
        }

        //Properties
        public string DefectId 
        { 
            get { return textDefectId.Text; }
            set {  textDefectId.Text = value; }
        }
        public string PartId 
        { 
            get { return textPartId.Text; }
            set {  textPartId.Text = value; }
        }
        public string DefectName 
        { 
            get { return textDefectName.Text; }
            set {  textDefectName.Text = value; }
        }
        public string SearchValue 
        { 
            get { return textSearch.Text; }
            set {  textSearch.Text = value; }
        }
        public bool IsEdit 
        { 
            get { return isEdit; }
            set {  isEdit = value; }
        }
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set {  isSuccessful = value; }
        }
        public string Message 
        { 
            get { return message; }
            set { message = value; } 
        }

        //Event
        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler CancleEvent;

        //methods
        public void SetDefectListBindingSource(BindingSource defectList)
        {
            dataGridView1.DataSource = defectList;
        }

        //singleton pattern (open a single from instance)
        private static DefectView instance;
        public static DefectView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DefectView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
