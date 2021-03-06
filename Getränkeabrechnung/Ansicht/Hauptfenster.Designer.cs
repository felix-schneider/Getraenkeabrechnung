﻿namespace Getränkeabrechnung.Ansicht
{
    partial class Hauptfenster
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            BrightIdeasSoftware.OLVColumn Benutzerspalte;
            System.Windows.Forms.Label label1;
            BrightIdeasSoftware.OLVColumn KontoSpalte;
            BrightIdeasSoftware.OLVColumn KontostandSpalteKonten;
            System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
            BrightIdeasSoftware.OLVColumn AbrechnungSpalte;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
            this.Benutzerliste = new BrightIdeasSoftware.ObjectListView();
            this.GuthabenSpalte = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Kontenliste = new BrightIdeasSoftware.ObjectListView();
            this.neuesKontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Abrechnungsliste = new BrightIdeasSoftware.ObjectListView();
            this.StatusSpalte = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.BenutzerKnopf = new System.Windows.Forms.Button();
            this.ProduktKnopf = new System.Windows.Forms.Button();
            this.EinkäufeKnopf = new System.Windows.Forms.Button();
            this.NeueAbrechnungKnopf = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            Benutzerspalte = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            label1 = new System.Windows.Forms.Label();
            KontoSpalte = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            KontostandSpalteKonten = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            AbrechnungSpalte = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Benutzerliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kontenliste)).BeginInit();
            contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Abrechnungsliste)).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(this.Benutzerliste, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(this.Kontenliste, 1, 0);
            tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.4013F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.5987F));
            tableLayoutPanel1.Size = new System.Drawing.Size(484, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Benutzerliste
            // 
            this.Benutzerliste.AllColumns.Add(Benutzerspalte);
            this.Benutzerliste.AllColumns.Add(this.GuthabenSpalte);
            this.Benutzerliste.AlternateRowBackColor = System.Drawing.SystemColors.ButtonFace;
            this.Benutzerliste.CellEditUseWholeCell = false;
            this.Benutzerliste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Benutzerspalte,
            this.GuthabenSpalte});
            this.Benutzerliste.Cursor = System.Windows.Forms.Cursors.Default;
            this.Benutzerliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Benutzerliste.FullRowSelect = true;
            this.Benutzerliste.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Benutzerliste.Location = new System.Drawing.Point(10, 80);
            this.Benutzerliste.Margin = new System.Windows.Forms.Padding(10);
            this.Benutzerliste.MinimumSize = new System.Drawing.Size(100, 50);
            this.Benutzerliste.MultiSelect = false;
            this.Benutzerliste.Name = "Benutzerliste";
            this.Benutzerliste.SelectColumnsOnRightClick = false;
            this.Benutzerliste.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.Benutzerliste.ShowGroups = false;
            this.Benutzerliste.ShowSortIndicators = false;
            this.Benutzerliste.Size = new System.Drawing.Size(222, 371);
            this.Benutzerliste.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Benutzerliste.TabIndex = 4;
            this.Benutzerliste.UseAlternatingBackColors = true;
            this.Benutzerliste.UseCellFormatEvents = true;
            this.Benutzerliste.UseCompatibleStateImageBehavior = false;
            this.Benutzerliste.UseFiltering = true;
            this.Benutzerliste.View = System.Windows.Forms.View.Details;
            this.Benutzerliste.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.Benutzerliste_FormatCell);
            this.Benutzerliste.ItemActivate += new System.EventHandler(this.Benutzerliste_ItemActivate);
            // 
            // Benutzerspalte
            // 
            Benutzerspalte.AspectName = "Anzeigename";
            Benutzerspalte.FillsFreeSpace = true;
            Benutzerspalte.Text = "Benutzer";
            Benutzerspalte.Width = 100;
            // 
            // GuthabenSpalte
            // 
            this.GuthabenSpalte.AspectName = "Guthaben";
            this.GuthabenSpalte.AspectToStringFormat = "{0:C}";
            this.GuthabenSpalte.Text = "Guthaben";
            this.GuthabenSpalte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GuthabenSpalte.Width = 100;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(236, 70);
            label1.TabIndex = 1;
            label1.Text = "Übersicht";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Kontenliste
            // 
            this.Kontenliste.AllColumns.Add(KontoSpalte);
            this.Kontenliste.AllColumns.Add(KontostandSpalteKonten);
            this.Kontenliste.CellEditUseWholeCell = false;
            this.Kontenliste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            KontoSpalte,
            KontostandSpalteKonten});
            this.Kontenliste.ContextMenuStrip = contextMenuStrip1;
            this.Kontenliste.Cursor = System.Windows.Forms.Cursors.Default;
            this.Kontenliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Kontenliste.EmptyListMsg = "Keine Konten angelegt";
            this.Kontenliste.FullRowSelect = true;
            this.Kontenliste.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.Kontenliste.HeaderUsesThemes = true;
            this.Kontenliste.Location = new System.Drawing.Point(252, 10);
            this.Kontenliste.Margin = new System.Windows.Forms.Padding(10);
            this.Kontenliste.MinimumSize = new System.Drawing.Size(210, 50);
            this.Kontenliste.MultiSelect = false;
            this.Kontenliste.Name = "Kontenliste";
            this.Kontenliste.SelectColumnsOnRightClick = false;
            this.Kontenliste.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.Kontenliste.ShowGroups = false;
            this.Kontenliste.Size = new System.Drawing.Size(222, 50);
            this.Kontenliste.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Kontenliste.TabIndex = 2;
            this.Kontenliste.TabStop = false;
            this.Kontenliste.UseCompatibleStateImageBehavior = false;
            this.Kontenliste.View = System.Windows.Forms.View.Details;
            this.Kontenliste.ItemActivate += new System.EventHandler(this.Kontenliste_ItemActivate);
            // 
            // KontoSpalte
            // 
            KontoSpalte.AspectName = "Name";
            KontoSpalte.FillsFreeSpace = true;
            KontoSpalte.Text = "Konto";
            KontoSpalte.Width = 100;
            // 
            // KontostandSpalteKonten
            // 
            KontostandSpalteKonten.AspectName = "Kontostand";
            KontostandSpalteKonten.AspectToStringFormat = "{0:C}";
            KontostandSpalteKonten.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.FixedBounds;
            KontostandSpalteKonten.Text = "Kontostand";
            KontostandSpalteKonten.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            KontostandSpalteKonten.Width = 100;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesKontoToolStripMenuItem});
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(143, 26);
            // 
            // neuesKontoToolStripMenuItem
            // 
            this.neuesKontoToolStripMenuItem.Name = "neuesKontoToolStripMenuItem";
            this.neuesKontoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.neuesKontoToolStripMenuItem.Text = "Neues Konto";
            this.neuesKontoToolStripMenuItem.Click += new System.EventHandler(this.neuesKontoToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Abrechnungsliste, 0, 0);
            this.tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(242, 70);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(242, 391);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Abrechnungsliste
            // 
            this.Abrechnungsliste.AllColumns.Add(AbrechnungSpalte);
            this.Abrechnungsliste.AllColumns.Add(this.StatusSpalte);
            this.Abrechnungsliste.AlternateRowBackColor = System.Drawing.SystemColors.ButtonFace;
            this.Abrechnungsliste.CellEditUseWholeCell = false;
            this.Abrechnungsliste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            AbrechnungSpalte,
            this.StatusSpalte});
            this.Abrechnungsliste.Cursor = System.Windows.Forms.Cursors.Default;
            this.Abrechnungsliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Abrechnungsliste.FullRowSelect = true;
            this.Abrechnungsliste.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Abrechnungsliste.Location = new System.Drawing.Point(10, 10);
            this.Abrechnungsliste.Margin = new System.Windows.Forms.Padding(10);
            this.Abrechnungsliste.MultiSelect = false;
            this.Abrechnungsliste.Name = "Abrechnungsliste";
            this.Abrechnungsliste.SelectColumnsOnRightClick = false;
            this.Abrechnungsliste.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.Abrechnungsliste.ShowGroups = false;
            this.Abrechnungsliste.Size = new System.Drawing.Size(222, 175);
            this.Abrechnungsliste.TabIndex = 3;
            this.Abrechnungsliste.UseAlternatingBackColors = true;
            this.Abrechnungsliste.UseCellFormatEvents = true;
            this.Abrechnungsliste.UseCompatibleStateImageBehavior = false;
            this.Abrechnungsliste.View = System.Windows.Forms.View.Details;
            this.Abrechnungsliste.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.Abrechnungsliste_FormatCell);
            this.Abrechnungsliste.ItemActivate += new System.EventHandler(this.Abrechnungsliste_ItemActivate);
            // 
            // AbrechnungSpalte
            // 
            AbrechnungSpalte.AspectName = "Name";
            AbrechnungSpalte.FillsFreeSpace = true;
            AbrechnungSpalte.Text = "Letzte Abrechnungen";
            // 
            // StatusSpalte
            // 
            this.StatusSpalte.AspectName = "Gebucht";
            this.StatusSpalte.Text = "Status";
            this.StatusSpalte.Width = 120;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(this.BenutzerKnopf, 0, 0);
            tableLayoutPanel3.Controls.Add(this.ProduktKnopf, 0, 1);
            tableLayoutPanel3.Controls.Add(this.EinkäufeKnopf, 0, 2);
            tableLayoutPanel3.Controls.Add(this.NeueAbrechnungKnopf, 0, 3);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(0, 195);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new System.Drawing.Size(242, 196);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // BenutzerKnopf
            // 
            this.BenutzerKnopf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BenutzerKnopf.Location = new System.Drawing.Point(10, 3);
            this.BenutzerKnopf.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.BenutzerKnopf.Name = "BenutzerKnopf";
            this.BenutzerKnopf.Size = new System.Drawing.Size(222, 34);
            this.BenutzerKnopf.TabIndex = 0;
            this.BenutzerKnopf.Text = "Benutzer Verwalten...";
            this.BenutzerKnopf.UseVisualStyleBackColor = true;
            this.BenutzerKnopf.Click += new System.EventHandler(this.BenutzerKnopf_Click);
            // 
            // ProduktKnopf
            // 
            this.ProduktKnopf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProduktKnopf.Location = new System.Drawing.Point(10, 43);
            this.ProduktKnopf.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.ProduktKnopf.Name = "ProduktKnopf";
            this.ProduktKnopf.Size = new System.Drawing.Size(222, 34);
            this.ProduktKnopf.TabIndex = 1;
            this.ProduktKnopf.Text = "Produkte Verwalten...";
            this.ProduktKnopf.UseVisualStyleBackColor = true;
            this.ProduktKnopf.Click += new System.EventHandler(this.ProduktKnopf_Click);
            // 
            // EinkäufeKnopf
            // 
            this.EinkäufeKnopf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EinkäufeKnopf.Location = new System.Drawing.Point(10, 83);
            this.EinkäufeKnopf.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.EinkäufeKnopf.Name = "EinkäufeKnopf";
            this.EinkäufeKnopf.Size = new System.Drawing.Size(222, 34);
            this.EinkäufeKnopf.TabIndex = 2;
            this.EinkäufeKnopf.Text = "Einkäufe Verwalten...";
            this.EinkäufeKnopf.UseVisualStyleBackColor = true;
            this.EinkäufeKnopf.Click += new System.EventHandler(this.EinkäufeKnopf_Click);
            // 
            // NeueAbrechnungKnopf
            // 
            this.NeueAbrechnungKnopf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NeueAbrechnungKnopf.Location = new System.Drawing.Point(10, 123);
            this.NeueAbrechnungKnopf.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.NeueAbrechnungKnopf.Name = "NeueAbrechnungKnopf";
            this.NeueAbrechnungKnopf.Size = new System.Drawing.Size(222, 34);
            this.NeueAbrechnungKnopf.TabIndex = 3;
            this.NeueAbrechnungKnopf.Text = "Neue Abrechnung...";
            this.NeueAbrechnungKnopf.UseVisualStyleBackColor = true;
            this.NeueAbrechnungKnopf.Click += new System.EventHandler(this.NeueAbrechnungKnopf_Click);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 39);
            this.Name = "Hauptfenster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hauptfenster_FormClosing);
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Benutzerliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kontenliste)).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Abrechnungsliste)).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BrightIdeasSoftware.ObjectListView Kontenliste;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private BrightIdeasSoftware.ObjectListView Abrechnungsliste;
        private BrightIdeasSoftware.OLVColumn StatusSpalte;
        private BrightIdeasSoftware.ObjectListView Benutzerliste;
        private BrightIdeasSoftware.OLVColumn GuthabenSpalte;
        private System.Windows.Forms.ToolStripMenuItem neuesKontoToolStripMenuItem;
        private System.Windows.Forms.Button BenutzerKnopf;
        private System.Windows.Forms.Button ProduktKnopf;
        private System.Windows.Forms.Button EinkäufeKnopf;
        private System.Windows.Forms.Button NeueAbrechnungKnopf;
    }
}
