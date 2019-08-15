using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace SqlStatementGenerator
{
    partial class SqlGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSelectSQL = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgTableInfo = new System.Windows.Forms.DataGrid();
            this.btnShowQueryResults = new System.Windows.Forms.Button();
            this.lblIncludeFields = new System.Windows.Forms.Label();
            this.chklstIncludeFields = new System.Windows.Forms.CheckedListBox();
            this.lblTargetTable = new System.Windows.Forms.Label();
            this.txtTargetTable = new System.Windows.Forms.TextBox();
            this.cmbSqlType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTableInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSelectSQL
            // 
            this.txtSelectSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectSQL.Location = new System.Drawing.Point(350, 47);
            this.txtSelectSQL.Multiline = true;
            this.txtSelectSQL.Name = "txtSelectSQL";
            this.txtSelectSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSelectSQL.Size = new System.Drawing.Size(198, 76);
            this.txtSelectSQL.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(577, 75);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(261, 48);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate SQL Statements";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgTableInfo
            // 
            this.dgTableInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTableInfo.CaptionText = "Results from SELECT Query:";
            this.dgTableInfo.DataMember = "";
            this.dgTableInfo.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgTableInfo.Location = new System.Drawing.Point(14, 132);
            this.dgTableInfo.Name = "dgTableInfo";
            this.dgTableInfo.Size = new System.Drawing.Size(534, 430);
            this.dgTableInfo.TabIndex = 63;
            // 
            // btnShowQueryResults
            // 
            this.btnShowQueryResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowQueryResults.Enabled = false;
            this.btnShowQueryResults.Location = new System.Drawing.Point(577, 18);
            this.btnShowQueryResults.Name = "btnShowQueryResults";
            this.btnShowQueryResults.Size = new System.Drawing.Size(261, 48);
            this.btnShowQueryResults.TabIndex = 6;
            this.btnShowQueryResults.Text = "Show SQL / Table Results";
            this.btnShowQueryResults.Click += new System.EventHandler(this.btnShowQueryResults_Click);
            // 
            // lblIncludeFields
            // 
            this.lblIncludeFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncludeFields.Location = new System.Drawing.Point(566, 355);
            this.lblIncludeFields.Name = "lblIncludeFields";
            this.lblIncludeFields.Size = new System.Drawing.Size(248, 21);
            this.lblIncludeFields.TabIndex = 9;
            this.lblIncludeFields.Text = "Check the fields to include:";
            // 
            // chklstIncludeFields
            // 
            this.chklstIncludeFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstIncludeFields.Location = new System.Drawing.Point(569, 380);
            this.chklstIncludeFields.Name = "chklstIncludeFields";
            this.chklstIncludeFields.Size = new System.Drawing.Size(267, 151);
            this.chklstIncludeFields.TabIndex = 10;
            // 
            // lblTargetTable
            // 
            this.lblTargetTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTargetTable.Location = new System.Drawing.Point(566, 282);
            this.lblTargetTable.Name = "lblTargetTable";
            this.lblTargetTable.Size = new System.Drawing.Size(266, 21);
            this.lblTargetTable.TabIndex = 7;
            this.lblTargetTable.Text = "Table name for generated SQL:";
            // 
            // txtTargetTable
            // 
            this.txtTargetTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetTable.Location = new System.Drawing.Point(569, 305);
            this.txtTargetTable.Name = "txtTargetTable";
            this.txtTargetTable.Size = new System.Drawing.Size(267, 26);
            this.txtTargetTable.TabIndex = 8;
            // 
            // cmbSqlType
            // 
            this.cmbSqlType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSqlType.DropDownHeight = 500;
            this.cmbSqlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSqlType.IntegralHeight = false;
            this.cmbSqlType.Items.AddRange(new object[] {
            "INSERT Statements",
            "UPDATE Statements",
            "DELETE Statements"});
            this.cmbSqlType.Location = new System.Drawing.Point(569, 237);
            this.cmbSqlType.Name = "cmbSqlType";
            this.cmbSqlType.Size = new System.Drawing.Size(267, 28);
            this.cmbSqlType.TabIndex = 69;
            this.cmbSqlType.SelectedIndexChanged += new System.EventHandler(this.cmbSqlType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(564, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "SQL Statement Type:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(346, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "SELECT SQL Query:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Selected Database / Table:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(577, 132);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(261, 48);
            this.btnClose.TabIndex = 74;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbTables
            // 
            this.cmbTables.DataBindings.Add(new System.Windows.Forms.Binding("ValueMember", global::SqlStatementGenerator.Properties.Settings.Default, "cmbLastTableUsed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbTables.DropDownHeight = 500;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.IntegralHeight = false;
            this.cmbTables.Location = new System.Drawing.Point(19, 86);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(298, 28);
            this.cmbTables.TabIndex = 67;
            this.cmbTables.ValueMember = global::SqlStatementGenerator.Properties.Settings.Default.cmbLastTableUsed;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SqlStatementGenerator.Properties.Settings.Default, "cmbLastDatabaseName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbDatabases.DataBindings.Add(new System.Windows.Forms.Binding("ValueMember", global::SqlStatementGenerator.Properties.Settings.Default, "cmbLastDatabaseName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbDatabases.DropDownHeight = 500;
            this.cmbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabases.IntegralHeight = false;
            this.cmbDatabases.Location = new System.Drawing.Point(19, 47);
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(298, 28);
            this.cmbDatabases.TabIndex = 66;
            this.cmbDatabases.Text = global::SqlStatementGenerator.Properties.Settings.Default.cmbLastDatabaseName;
            this.cmbDatabases.ValueMember = global::SqlStatementGenerator.Properties.Settings.Default.cmbLastDatabaseName;
            this.cmbDatabases.SelectedIndexChanged += new System.EventHandler(this.cmbDatabases_SelectedIndexChanged);
            // 
            // SqlGenerator
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(857, 579);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSqlType);
            this.Controls.Add(this.cmbTables);
            this.Controls.Add(this.cmbDatabases);
            this.Controls.Add(this.txtTargetTable);
            this.Controls.Add(this.txtSelectSQL);
            this.Controls.Add(this.lblTargetTable);
            this.Controls.Add(this.chklstIncludeFields);
            this.Controls.Add(this.lblIncludeFields);
            this.Controls.Add(this.btnShowQueryResults);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dgTableInfo);
            this.Name = "SqlGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Statement Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SqlGenerator_FormClosed);
            this.Load += new System.EventHandler(this.SqlGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTableInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGrid dgTableInfo;
        private System.Windows.Forms.TextBox txtSelectSQL;
        private System.Windows.Forms.Button btnShowQueryResults;
        private System.Windows.Forms.Label lblIncludeFields;
        private System.Windows.Forms.CheckedListBox chklstIncludeFields;
        private System.Windows.Forms.Label lblTargetTable;
        private System.Windows.Forms.TextBox txtTargetTable;

        private ComboBox cmbTables;
        private ComboBox cmbDatabases;
        private ComboBox cmbSqlType;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnClose;
            

    }
}
