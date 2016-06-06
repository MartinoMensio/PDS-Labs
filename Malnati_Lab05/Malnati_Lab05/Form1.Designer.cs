namespace Malnati_Lab05
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.panelZonaAzioni = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.tableLayoutPanelFormInputs = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFormPrincipale = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFormSecondario = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.buttonCerca = new System.Windows.Forms.Button();
            this.tableLayoutPanelFormPrincipaleLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFormPrincipaleRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFormSecondarioLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFormSecondarioRight = new System.Windows.Forms.TableLayoutPanel();
            this.labelIndirizzo = new System.Windows.Forms.Label();
            this.labelTipologia = new System.Windows.Forms.Label();
            this.labelContratto = new System.Windows.Forms.Label();
            this.labelPrezzo = new System.Windows.Forms.Label();
            this.textBoxIndirizzo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelContratto = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonContrattoAffitto = new System.Windows.Forms.RadioButton();
            this.radioButtonContrattoVendita = new System.Windows.Forms.RadioButton();
            this.comboBoxTipologia = new System.Windows.Forms.ComboBox();
            this.panelFormInputs = new System.Windows.Forms.Panel();
            this.labelSuperficieMinima = new System.Windows.Forms.Label();
            this.labelPiano = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanelPrezzo = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMeno = new System.Windows.Forms.Button();
            this.buttonPiu = new System.Windows.Forms.Button();
            this.textBoxPrezzo = new System.Windows.Forms.TextBox();
            this.textBoxSuperficieMinima = new System.Windows.Forms.TextBox();
            this.comboBoxPiano = new System.Windows.Forms.ComboBox();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelZonaAzioni.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.tableLayoutPanelFormInputs.SuspendLayout();
            this.tableLayoutPanelFormPrincipale.SuspendLayout();
            this.tableLayoutPanelFormSecondario.SuspendLayout();
            this.tableLayoutPanelFormPrincipaleLeft.SuspendLayout();
            this.tableLayoutPanelFormPrincipaleRight.SuspendLayout();
            this.tableLayoutPanelFormSecondarioLeft.SuspendLayout();
            this.tableLayoutPanelFormSecondarioRight.SuspendLayout();
            this.tableLayoutPanelContratto.SuspendLayout();
            this.panelFormInputs.SuspendLayout();
            this.tableLayoutPanelPrezzo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(611, 40);
            this.panelHeader.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.gmap, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelForm, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(611, 277);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(3, 3);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 20;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(299, 271);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 2D;
            // 
            // panelZonaAzioni
            // 
            this.panelZonaAzioni.Controls.Add(this.buttonCerca);
            this.panelZonaAzioni.Controls.Add(this.buttonAnnulla);
            this.panelZonaAzioni.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelZonaAzioni.Location = new System.Drawing.Point(0, 239);
            this.panelZonaAzioni.Name = "panelZonaAzioni";
            this.panelZonaAzioni.Size = new System.Drawing.Size(300, 32);
            this.panelZonaAzioni.TabIndex = 0;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.panelFormInputs);
            this.panelForm.Controls.Add(this.panelZonaAzioni);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(308, 3);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(300, 271);
            this.panelForm.TabIndex = 1;
            // 
            // tableLayoutPanelFormInputs
            // 
            this.tableLayoutPanelFormInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelFormInputs.AutoSize = true;
            this.tableLayoutPanelFormInputs.ColumnCount = 1;
            this.tableLayoutPanelFormInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFormInputs.Controls.Add(this.tableLayoutPanelFormPrincipale, 0, 0);
            this.tableLayoutPanelFormInputs.Controls.Add(this.tableLayoutPanelFormSecondario, 0, 1);
            this.tableLayoutPanelFormInputs.Location = new System.Drawing.Point(0, -3);
            this.tableLayoutPanelFormInputs.Name = "tableLayoutPanelFormInputs";
            this.tableLayoutPanelFormInputs.RowCount = 2;
            this.tableLayoutPanelFormInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFormInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFormInputs.Size = new System.Drawing.Size(300, 242);
            this.tableLayoutPanelFormInputs.TabIndex = 1;
            // 
            // tableLayoutPanelFormPrincipale
            // 
            this.tableLayoutPanelFormPrincipale.ColumnCount = 2;
            this.tableLayoutPanelFormPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFormPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFormPrincipale.Controls.Add(this.tableLayoutPanelFormPrincipaleLeft, 0, 0);
            this.tableLayoutPanelFormPrincipale.Controls.Add(this.tableLayoutPanelFormPrincipaleRight, 1, 0);
            this.tableLayoutPanelFormPrincipale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFormPrincipale.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelFormPrincipale.MinimumSize = new System.Drawing.Size(0, 50);
            this.tableLayoutPanelFormPrincipale.Name = "tableLayoutPanelFormPrincipale";
            this.tableLayoutPanelFormPrincipale.RowCount = 1;
            this.tableLayoutPanelFormPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFormPrincipale.Size = new System.Drawing.Size(294, 130);
            this.tableLayoutPanelFormPrincipale.TabIndex = 0;
            // 
            // tableLayoutPanelFormSecondario
            // 
            this.tableLayoutPanelFormSecondario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanelFormSecondario.ColumnCount = 2;
            this.tableLayoutPanelFormSecondario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFormSecondario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFormSecondario.Controls.Add(this.tableLayoutPanelFormSecondarioLeft, 0, 0);
            this.tableLayoutPanelFormSecondario.Controls.Add(this.tableLayoutPanelFormSecondarioRight, 1, 0);
            this.tableLayoutPanelFormSecondario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFormSecondario.Location = new System.Drawing.Point(3, 139);
            this.tableLayoutPanelFormSecondario.Name = "tableLayoutPanelFormSecondario";
            this.tableLayoutPanelFormSecondario.RowCount = 1;
            this.tableLayoutPanelFormSecondario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFormSecondario.Size = new System.Drawing.Size(294, 100);
            this.tableLayoutPanelFormSecondario.TabIndex = 1;
            // 
            // buttonAnnulla
            // 
            this.buttonAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnnulla.Location = new System.Drawing.Point(141, 3);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnulla.TabIndex = 0;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.UseVisualStyleBackColor = true;
            // 
            // buttonCerca
            // 
            this.buttonCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerca.Location = new System.Drawing.Point(222, 3);
            this.buttonCerca.Name = "buttonCerca";
            this.buttonCerca.Size = new System.Drawing.Size(75, 23);
            this.buttonCerca.TabIndex = 1;
            this.buttonCerca.Text = "Cerca";
            this.buttonCerca.UseVisualStyleBackColor = true;
            this.buttonCerca.Click += new System.EventHandler(this.buttonCerca_Click);
            // 
            // tableLayoutPanelFormPrincipaleLeft
            // 
            this.tableLayoutPanelFormPrincipaleLeft.ColumnCount = 1;
            this.tableLayoutPanelFormPrincipaleLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFormPrincipaleLeft.Controls.Add(this.labelIndirizzo, 0, 0);
            this.tableLayoutPanelFormPrincipaleLeft.Controls.Add(this.labelTipologia, 0, 2);
            this.tableLayoutPanelFormPrincipaleLeft.Controls.Add(this.textBoxIndirizzo, 0, 1);
            this.tableLayoutPanelFormPrincipaleLeft.Controls.Add(this.comboBoxTipologia, 0, 3);
            this.tableLayoutPanelFormPrincipaleLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFormPrincipaleLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelFormPrincipaleLeft.Name = "tableLayoutPanelFormPrincipaleLeft";
            this.tableLayoutPanelFormPrincipaleLeft.RowCount = 4;
            this.tableLayoutPanelFormPrincipaleLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFormPrincipaleLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFormPrincipaleLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFormPrincipaleLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFormPrincipaleLeft.Size = new System.Drawing.Size(141, 124);
            this.tableLayoutPanelFormPrincipaleLeft.TabIndex = 0;
            // 
            // tableLayoutPanelFormPrincipaleRight
            // 
            this.tableLayoutPanelFormPrincipaleRight.ColumnCount = 1;
            this.tableLayoutPanelFormPrincipaleRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFormPrincipaleRight.Controls.Add(this.labelContratto, 0, 0);
            this.tableLayoutPanelFormPrincipaleRight.Controls.Add(this.labelPrezzo, 0, 2);
            this.tableLayoutPanelFormPrincipaleRight.Controls.Add(this.tableLayoutPanelContratto, 0, 1);
            this.tableLayoutPanelFormPrincipaleRight.Controls.Add(this.tableLayoutPanelPrezzo, 0, 3);
            this.tableLayoutPanelFormPrincipaleRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFormPrincipaleRight.Location = new System.Drawing.Point(150, 3);
            this.tableLayoutPanelFormPrincipaleRight.Name = "tableLayoutPanelFormPrincipaleRight";
            this.tableLayoutPanelFormPrincipaleRight.RowCount = 4;
            this.tableLayoutPanelFormPrincipaleRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFormPrincipaleRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFormPrincipaleRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFormPrincipaleRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFormPrincipaleRight.Size = new System.Drawing.Size(141, 124);
            this.tableLayoutPanelFormPrincipaleRight.TabIndex = 1;
            // 
            // tableLayoutPanelFormSecondarioLeft
            // 
            this.tableLayoutPanelFormSecondarioLeft.ColumnCount = 1;
            this.tableLayoutPanelFormSecondarioLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFormSecondarioLeft.Controls.Add(this.labelSuperficieMinima, 0, 0);
            this.tableLayoutPanelFormSecondarioLeft.Controls.Add(this.textBoxSuperficieMinima, 0, 1);
            this.tableLayoutPanelFormSecondarioLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFormSecondarioLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelFormSecondarioLeft.Name = "tableLayoutPanelFormSecondarioLeft";
            this.tableLayoutPanelFormSecondarioLeft.RowCount = 2;
            this.tableLayoutPanelFormSecondarioLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFormSecondarioLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFormSecondarioLeft.Size = new System.Drawing.Size(141, 94);
            this.tableLayoutPanelFormSecondarioLeft.TabIndex = 0;
            // 
            // tableLayoutPanelFormSecondarioRight
            // 
            this.tableLayoutPanelFormSecondarioRight.ColumnCount = 1;
            this.tableLayoutPanelFormSecondarioRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFormSecondarioRight.Controls.Add(this.labelPiano, 0, 0);
            this.tableLayoutPanelFormSecondarioRight.Controls.Add(this.comboBoxPiano, 0, 1);
            this.tableLayoutPanelFormSecondarioRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFormSecondarioRight.Location = new System.Drawing.Point(150, 3);
            this.tableLayoutPanelFormSecondarioRight.Name = "tableLayoutPanelFormSecondarioRight";
            this.tableLayoutPanelFormSecondarioRight.RowCount = 2;
            this.tableLayoutPanelFormSecondarioRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFormSecondarioRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFormSecondarioRight.Size = new System.Drawing.Size(141, 94);
            this.tableLayoutPanelFormSecondarioRight.TabIndex = 1;
            // 
            // labelIndirizzo
            // 
            this.labelIndirizzo.AutoSize = true;
            this.labelIndirizzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIndirizzo.Location = new System.Drawing.Point(3, 0);
            this.labelIndirizzo.Name = "labelIndirizzo";
            this.labelIndirizzo.Size = new System.Drawing.Size(135, 20);
            this.labelIndirizzo.TabIndex = 0;
            this.labelIndirizzo.Text = "Indirizzo/Città";
            // 
            // labelTipologia
            // 
            this.labelTipologia.AutoSize = true;
            this.labelTipologia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTipologia.Location = new System.Drawing.Point(3, 62);
            this.labelTipologia.Name = "labelTipologia";
            this.labelTipologia.Size = new System.Drawing.Size(135, 20);
            this.labelTipologia.TabIndex = 1;
            this.labelTipologia.Text = "Tipologia";
            // 
            // labelContratto
            // 
            this.labelContratto.AutoSize = true;
            this.labelContratto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelContratto.Location = new System.Drawing.Point(3, 0);
            this.labelContratto.Name = "labelContratto";
            this.labelContratto.Size = new System.Drawing.Size(135, 20);
            this.labelContratto.TabIndex = 0;
            this.labelContratto.Text = "Contratto";
            // 
            // labelPrezzo
            // 
            this.labelPrezzo.AutoSize = true;
            this.labelPrezzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrezzo.Location = new System.Drawing.Point(3, 62);
            this.labelPrezzo.Name = "labelPrezzo";
            this.labelPrezzo.Size = new System.Drawing.Size(135, 20);
            this.labelPrezzo.TabIndex = 1;
            this.labelPrezzo.Text = "Prezzo";
            // 
            // textBoxIndirizzo
            // 
            this.textBoxIndirizzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIndirizzo.Location = new System.Drawing.Point(3, 23);
            this.textBoxIndirizzo.MinimumSize = new System.Drawing.Size(0, 20);
            this.textBoxIndirizzo.Name = "textBoxIndirizzo";
            this.textBoxIndirizzo.Size = new System.Drawing.Size(135, 20);
            this.textBoxIndirizzo.TabIndex = 2;
            // 
            // tableLayoutPanelContratto
            // 
            this.tableLayoutPanelContratto.ColumnCount = 2;
            this.tableLayoutPanelContratto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContratto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContratto.Controls.Add(this.radioButtonContrattoAffitto, 0, 0);
            this.tableLayoutPanelContratto.Controls.Add(this.radioButtonContrattoVendita, 1, 0);
            this.tableLayoutPanelContratto.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelContratto.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanelContratto.Name = "tableLayoutPanelContratto";
            this.tableLayoutPanelContratto.RowCount = 1;
            this.tableLayoutPanelContratto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContratto.Size = new System.Drawing.Size(135, 30);
            this.tableLayoutPanelContratto.TabIndex = 2;
            // 
            // radioButtonContrattoAffitto
            // 
            this.radioButtonContrattoAffitto.AutoSize = true;
            this.radioButtonContrattoAffitto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonContrattoAffitto.Location = new System.Drawing.Point(3, 3);
            this.radioButtonContrattoAffitto.Name = "radioButtonContrattoAffitto";
            this.radioButtonContrattoAffitto.Size = new System.Drawing.Size(61, 24);
            this.radioButtonContrattoAffitto.TabIndex = 0;
            this.radioButtonContrattoAffitto.TabStop = true;
            this.radioButtonContrattoAffitto.Text = "Affitto";
            this.radioButtonContrattoAffitto.UseVisualStyleBackColor = true;
            // 
            // radioButtonContrattoVendita
            // 
            this.radioButtonContrattoVendita.AutoSize = true;
            this.radioButtonContrattoVendita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonContrattoVendita.Location = new System.Drawing.Point(70, 3);
            this.radioButtonContrattoVendita.Name = "radioButtonContrattoVendita";
            this.radioButtonContrattoVendita.Size = new System.Drawing.Size(62, 24);
            this.radioButtonContrattoVendita.TabIndex = 1;
            this.radioButtonContrattoVendita.TabStop = true;
            this.radioButtonContrattoVendita.Text = "Vendita";
            this.radioButtonContrattoVendita.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipologia
            // 
            this.comboBoxTipologia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTipologia.FormattingEnabled = true;
            this.comboBoxTipologia.Location = new System.Drawing.Point(3, 85);
            this.comboBoxTipologia.Name = "comboBoxTipologia";
            this.comboBoxTipologia.Size = new System.Drawing.Size(135, 21);
            this.comboBoxTipologia.TabIndex = 3;
            // 
            // panelFormInputs
            // 
            this.panelFormInputs.AutoScroll = true;
            this.panelFormInputs.Controls.Add(this.tableLayoutPanelFormInputs);
            this.panelFormInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormInputs.Location = new System.Drawing.Point(0, 0);
            this.panelFormInputs.Name = "panelFormInputs";
            this.panelFormInputs.Size = new System.Drawing.Size(300, 239);
            this.panelFormInputs.TabIndex = 1;
            // 
            // labelSuperficieMinima
            // 
            this.labelSuperficieMinima.AutoSize = true;
            this.labelSuperficieMinima.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSuperficieMinima.Location = new System.Drawing.Point(3, 0);
            this.labelSuperficieMinima.Name = "labelSuperficieMinima";
            this.labelSuperficieMinima.Size = new System.Drawing.Size(135, 20);
            this.labelSuperficieMinima.TabIndex = 0;
            this.labelSuperficieMinima.Text = "Superficie minima";
            // 
            // labelPiano
            // 
            this.labelPiano.AutoSize = true;
            this.labelPiano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPiano.Location = new System.Drawing.Point(3, 0);
            this.labelPiano.Name = "labelPiano";
            this.labelPiano.Size = new System.Drawing.Size(135, 20);
            this.labelPiano.TabIndex = 0;
            this.labelPiano.Text = "Piano";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(268, 39);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Ricerca immobili";
            // 
            // tableLayoutPanelPrezzo
            // 
            this.tableLayoutPanelPrezzo.ColumnCount = 3;
            this.tableLayoutPanelPrezzo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelPrezzo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrezzo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelPrezzo.Controls.Add(this.buttonMeno, 0, 0);
            this.tableLayoutPanelPrezzo.Controls.Add(this.buttonPiu, 2, 0);
            this.tableLayoutPanelPrezzo.Controls.Add(this.textBoxPrezzo, 1, 0);
            this.tableLayoutPanelPrezzo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelPrezzo.Location = new System.Drawing.Point(3, 85);
            this.tableLayoutPanelPrezzo.Name = "tableLayoutPanelPrezzo";
            this.tableLayoutPanelPrezzo.RowCount = 1;
            this.tableLayoutPanelPrezzo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrezzo.Size = new System.Drawing.Size(135, 30);
            this.tableLayoutPanelPrezzo.TabIndex = 3;
            // 
            // buttonMeno
            // 
            this.buttonMeno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMeno.Location = new System.Drawing.Point(3, 3);
            this.buttonMeno.Name = "buttonMeno";
            this.buttonMeno.Size = new System.Drawing.Size(34, 24);
            this.buttonMeno.TabIndex = 0;
            this.buttonMeno.Text = "-";
            this.buttonMeno.UseVisualStyleBackColor = true;
            // 
            // buttonPiu
            // 
            this.buttonPiu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPiu.Location = new System.Drawing.Point(98, 3);
            this.buttonPiu.Name = "buttonPiu";
            this.buttonPiu.Size = new System.Drawing.Size(34, 24);
            this.buttonPiu.TabIndex = 1;
            this.buttonPiu.Text = "+";
            this.buttonPiu.UseVisualStyleBackColor = true;
            // 
            // textBoxPrezzo
            // 
            this.textBoxPrezzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPrezzo.Location = new System.Drawing.Point(43, 3);
            this.textBoxPrezzo.Name = "textBoxPrezzo";
            this.textBoxPrezzo.Size = new System.Drawing.Size(49, 20);
            this.textBoxPrezzo.TabIndex = 2;
            // 
            // textBoxSuperficieMinima
            // 
            this.textBoxSuperficieMinima.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSuperficieMinima.Location = new System.Drawing.Point(3, 23);
            this.textBoxSuperficieMinima.Name = "textBoxSuperficieMinima";
            this.textBoxSuperficieMinima.Size = new System.Drawing.Size(135, 20);
            this.textBoxSuperficieMinima.TabIndex = 1;
            // 
            // comboBoxPiano
            // 
            this.comboBoxPiano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPiano.FormattingEnabled = true;
            this.comboBoxPiano.Location = new System.Drawing.Point(3, 23);
            this.comboBoxPiano.Name = "comboBoxPiano";
            this.comboBoxPiano.Size = new System.Drawing.Size(135, 21);
            this.comboBoxPiano.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 317);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelZonaAzioni.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.tableLayoutPanelFormInputs.ResumeLayout(false);
            this.tableLayoutPanelFormPrincipale.ResumeLayout(false);
            this.tableLayoutPanelFormSecondario.ResumeLayout(false);
            this.tableLayoutPanelFormPrincipaleLeft.ResumeLayout(false);
            this.tableLayoutPanelFormPrincipaleLeft.PerformLayout();
            this.tableLayoutPanelFormPrincipaleRight.ResumeLayout(false);
            this.tableLayoutPanelFormPrincipaleRight.PerformLayout();
            this.tableLayoutPanelFormSecondarioLeft.ResumeLayout(false);
            this.tableLayoutPanelFormSecondarioLeft.PerformLayout();
            this.tableLayoutPanelFormSecondarioRight.ResumeLayout(false);
            this.tableLayoutPanelFormSecondarioRight.PerformLayout();
            this.tableLayoutPanelContratto.ResumeLayout(false);
            this.tableLayoutPanelContratto.PerformLayout();
            this.panelFormInputs.ResumeLayout(false);
            this.panelFormInputs.PerformLayout();
            this.tableLayoutPanelPrezzo.ResumeLayout(false);
            this.tableLayoutPanelPrezzo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFormInputs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFormPrincipale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFormSecondario;
        private System.Windows.Forms.Panel panelZonaAzioni;
        private System.Windows.Forms.Button buttonCerca;
        private System.Windows.Forms.Button buttonAnnulla;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFormPrincipaleLeft;
        private System.Windows.Forms.Label labelIndirizzo;
        private System.Windows.Forms.Label labelTipologia;
        private System.Windows.Forms.TextBox textBoxIndirizzo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFormPrincipaleRight;
        private System.Windows.Forms.Label labelContratto;
        private System.Windows.Forms.Label labelPrezzo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContratto;
        private System.Windows.Forms.RadioButton radioButtonContrattoAffitto;
        private System.Windows.Forms.RadioButton radioButtonContrattoVendita;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFormSecondarioLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFormSecondarioRight;
        private System.Windows.Forms.ComboBox comboBoxTipologia;
        private System.Windows.Forms.Panel panelFormInputs;
        private System.Windows.Forms.Label labelSuperficieMinima;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrezzo;
        private System.Windows.Forms.Button buttonMeno;
        private System.Windows.Forms.Button buttonPiu;
        private System.Windows.Forms.TextBox textBoxPrezzo;
        private System.Windows.Forms.TextBox textBoxSuperficieMinima;
        private System.Windows.Forms.Label labelPiano;
        private System.Windows.Forms.ComboBox comboBoxPiano;
    }
}

