namespace Presentacion
{
    partial class Anualidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anualidades));
            this.panelFormula = new System.Windows.Forms.Panel();
            this.lblResultadoFormula = new System.Windows.Forms.Label();
            this.lblResultFormula = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCalcular = new System.Windows.Forms.ComboBox();
            this.lblCalcular = new System.Windows.Forms.Label();
            this.lblCapitalInicial = new System.Windows.Forms.Label();
            this.lblTipoInteres = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txtPrimeraCuota = new System.Windows.Forms.TextBox();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.lblPorcentajeTI = new System.Windows.Forms.Label();
            this.txtTipoInteres = new System.Windows.Forms.TextBox();
            this.cmbTiempo = new System.Windows.Forms.ComboBox();
            this.lblDolarCI = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineCF = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineTiempo = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineTI = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineCI = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShapeTEA = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShapeVariacionPorcentual = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panelFormula.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormula
            // 
            this.panelFormula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormula.Controls.Add(this.lblResultadoFormula);
            this.panelFormula.Controls.Add(this.lblResultFormula);
            this.panelFormula.Controls.Add(this.lblFormula);
            this.panelFormula.Location = new System.Drawing.Point(256, 515);
            this.panelFormula.Margin = new System.Windows.Forms.Padding(4);
            this.panelFormula.Name = "panelFormula";
            this.panelFormula.Size = new System.Drawing.Size(551, 73);
            this.panelFormula.TabIndex = 74;
            this.panelFormula.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormula_Paint);
            // 
            // lblResultadoFormula
            // 
            this.lblResultadoFormula.AutoSize = true;
            this.lblResultadoFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoFormula.ForeColor = System.Drawing.Color.Navy;
            this.lblResultadoFormula.Location = new System.Drawing.Point(139, 23);
            this.lblResultadoFormula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultadoFormula.Name = "lblResultadoFormula";
            this.lblResultadoFormula.Size = new System.Drawing.Size(0, 25);
            this.lblResultadoFormula.TabIndex = 35;
            // 
            // lblResultFormula
            // 
            this.lblResultFormula.AutoSize = true;
            this.lblResultFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultFormula.ForeColor = System.Drawing.Color.Navy;
            this.lblResultFormula.Location = new System.Drawing.Point(133, 23);
            this.lblResultFormula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultFormula.Name = "lblResultFormula";
            this.lblResultFormula.Size = new System.Drawing.Size(0, 25);
            this.lblResultFormula.TabIndex = 34;
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.ForeColor = System.Drawing.Color.Navy;
            this.lblFormula.Location = new System.Drawing.Point(20, 23);
            this.lblFormula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(97, 25);
            this.lblFormula.TabIndex = 33;
            this.lblFormula.Text = "Formula:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblResultado);
            this.panel3.Controls.Add(this.txtResultado);
            this.panel3.Controls.Add(this.shapeContainer2);
            this.panel3.Location = new System.Drawing.Point(256, 609);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 83);
            this.panel3.TabIndex = 72;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Navy;
            this.lblResultado.Location = new System.Drawing.Point(20, 27);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(115, 25);
            this.lblResultado.TabIndex = 29;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Navy;
            this.txtResultado.Location = new System.Drawing.Point(220, 23);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(289, 23);
            this.txtResultado.TabIndex = 30;
            this.txtResultado.Text = "0";
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5});
            this.shapeContainer2.Size = new System.Drawing.Size(548, 81);
            this.shapeContainer2.TabIndex = 32;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.Navy;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 164;
            this.lineShape5.X2 = 384;
            this.lineShape5.Y1 = 41;
            this.lineShape5.Y2 = 41;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(256, 804);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(549, 58);
            this.btnReset.TabIndex = 71;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click1);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnCalcular.FlatAppearance.BorderSize = 2;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(256, 718);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(549, 58);
            this.btnCalcular.TabIndex = 70;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(256, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 60);
            this.panel1.TabIndex = 69;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(135, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 42);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Anualidades";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbCalcular);
            this.panel2.Controls.Add(this.lblCalcular);
            this.panel2.Location = new System.Drawing.Point(256, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 83);
            this.panel2.TabIndex = 68;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbCalcular
            // 
            this.cmbCalcular.BackColor = System.Drawing.Color.Navy;
            this.cmbCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCalcular.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmbCalcular.FormattingEnabled = true;
            this.cmbCalcular.Items.AddRange(new object[] {
            "Anualidad vencida",
            "Anualidad anticipada",
            "Anualidad diferida"});
            this.cmbCalcular.Location = new System.Drawing.Point(220, 23);
            this.cmbCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCalcular.Name = "cmbCalcular";
            this.cmbCalcular.Size = new System.Drawing.Size(295, 33);
            this.cmbCalcular.TabIndex = 33;
            this.cmbCalcular.Text = "Seleccionar";
            // 
            // lblCalcular
            // 
            this.lblCalcular.AutoSize = true;
            this.lblCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcular.ForeColor = System.Drawing.Color.Navy;
            this.lblCalcular.Location = new System.Drawing.Point(16, 30);
            this.lblCalcular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalcular.Name = "lblCalcular";
            this.lblCalcular.Size = new System.Drawing.Size(170, 25);
            this.lblCalcular.TabIndex = 32;
            this.lblCalcular.Text = "Quiero Calcular:";
            // 
            // lblCapitalInicial
            // 
            this.lblCapitalInicial.AutoSize = true;
            this.lblCapitalInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitalInicial.ForeColor = System.Drawing.Color.Navy;
            this.lblCapitalInicial.Location = new System.Drawing.Point(20, 15);
            this.lblCapitalInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapitalInicial.Name = "lblCapitalInicial";
            this.lblCapitalInicial.Size = new System.Drawing.Size(157, 25);
            this.lblCapitalInicial.TabIndex = 8;
            this.lblCapitalInicial.Text = "Primera Cuota:";
            // 
            // lblTipoInteres
            // 
            this.lblTipoInteres.AutoSize = true;
            this.lblTipoInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoInteres.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoInteres.Location = new System.Drawing.Point(20, 70);
            this.lblTipoInteres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoInteres.Name = "lblTipoInteres";
            this.lblTipoInteres.Size = new System.Drawing.Size(170, 25);
            this.lblTipoInteres.TabIndex = 10;
            this.lblTipoInteres.Text = "Tasa de Interes:";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.Navy;
            this.lblTiempo.Location = new System.Drawing.Point(20, 119);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(104, 25);
            this.lblTiempo.TabIndex = 11;
            this.lblTiempo.Text = "Periodos:";
            // 
            // txtPrimeraCuota
            // 
            this.txtPrimeraCuota.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrimeraCuota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimeraCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeraCuota.ForeColor = System.Drawing.Color.Navy;
            this.txtPrimeraCuota.Location = new System.Drawing.Point(271, 16);
            this.txtPrimeraCuota.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimeraCuota.Name = "txtPrimeraCuota";
            this.txtPrimeraCuota.Size = new System.Drawing.Size(244, 23);
            this.txtPrimeraCuota.TabIndex = 16;
            this.txtPrimeraCuota.Text = "0";
            // 
            // txtIngresos
            // 
            this.txtIngresos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresos.ForeColor = System.Drawing.Color.Navy;
            this.txtIngresos.Location = new System.Drawing.Point(241, 118);
            this.txtIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(48, 23);
            this.txtIngresos.TabIndex = 17;
            this.txtIngresos.Text = "0";
            // 
            // lblPorcentajeTI
            // 
            this.lblPorcentajeTI.AutoSize = true;
            this.lblPorcentajeTI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeTI.ForeColor = System.Drawing.Color.Navy;
            this.lblPorcentajeTI.Location = new System.Drawing.Point(288, 70);
            this.lblPorcentajeTI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentajeTI.Name = "lblPorcentajeTI";
            this.lblPorcentajeTI.Size = new System.Drawing.Size(31, 25);
            this.lblPorcentajeTI.TabIndex = 19;
            this.lblPorcentajeTI.Text = "%";
            // 
            // txtTipoInteres
            // 
            this.txtTipoInteres.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTipoInteres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoInteres.ForeColor = System.Drawing.Color.Navy;
            this.txtTipoInteres.Location = new System.Drawing.Point(241, 70);
            this.txtTipoInteres.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoInteres.Name = "txtTipoInteres";
            this.txtTipoInteres.Size = new System.Drawing.Size(40, 23);
            this.txtTipoInteres.TabIndex = 25;
            this.txtTipoInteres.Text = "0";
            // 
            // cmbTiempo
            // 
            this.cmbTiempo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbTiempo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTiempo.ForeColor = System.Drawing.Color.Navy;
            this.cmbTiempo.FormattingEnabled = true;
            this.cmbTiempo.Items.AddRange(new object[] {
            "Dias",
            "Meses",
            "Trimestres",
            "Semestres",
            "Años"});
            this.cmbTiempo.Location = new System.Drawing.Point(293, 112);
            this.cmbTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTiempo.Name = "cmbTiempo";
            this.cmbTiempo.Size = new System.Drawing.Size(220, 33);
            this.cmbTiempo.TabIndex = 26;
            this.cmbTiempo.Text = "Seleccionar";
            // 
            // lblDolarCI
            // 
            this.lblDolarCI.AutoSize = true;
            this.lblDolarCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarCI.ForeColor = System.Drawing.Color.Navy;
            this.lblDolarCI.Location = new System.Drawing.Point(237, 16);
            this.lblDolarCI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDolarCI.Name = "lblDolarCI";
            this.lblDolarCI.Size = new System.Drawing.Size(24, 25);
            this.lblDolarCI.TabIndex = 27;
            this.lblDolarCI.Text = "$";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblDolarCI);
            this.panel4.Controls.Add(this.cmbTiempo);
            this.panel4.Controls.Add(this.txtTipoInteres);
            this.panel4.Controls.Add(this.lblPorcentajeTI);
            this.panel4.Controls.Add(this.txtIngresos);
            this.panel4.Controls.Add(this.txtPrimeraCuota);
            this.panel4.Controls.Add(this.lblTiempo);
            this.panel4.Controls.Add(this.lblTipoInteres);
            this.panel4.Controls.Add(this.lblCapitalInicial);
            this.panel4.Controls.Add(this.shapeContainer3);
            this.panel4.Location = new System.Drawing.Point(255, 225);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(551, 268);
            this.panel4.TabIndex = 73;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineCF,
            this.lineTiempo,
            this.lineTI,
            this.lineCI});
            this.shapeContainer3.Size = new System.Drawing.Size(549, 266);
            this.shapeContainer3.TabIndex = 37;
            this.shapeContainer3.TabStop = false;
            // 
            // lineCF
            // 
            this.lineCF.BorderColor = System.Drawing.Color.Navy;
            this.lineCF.Name = "lineCF";
            this.lineCF.Visible = false;
            this.lineCF.X1 = 203;
            this.lineCF.X2 = 382;
            this.lineCF.Y1 = 160;
            this.lineCF.Y2 = 160;
            // 
            // lineTiempo
            // 
            this.lineTiempo.BorderColor = System.Drawing.Color.Navy;
            this.lineTiempo.Name = "lineTiempo";
            this.lineTiempo.X1 = 178;
            this.lineTiempo.X2 = 219;
            this.lineTiempo.Y1 = 119;
            this.lineTiempo.Y2 = 119;
            // 
            // lineTI
            // 
            this.lineTI.BorderColor = System.Drawing.Color.Navy;
            this.lineTI.Name = "lineTI";
            this.lineTI.X1 = 178;
            this.lineTI.X2 = 212;
            this.lineTI.Y1 = 79;
            this.lineTI.Y2 = 79;
            // 
            // lineCI
            // 
            this.lineCI.BorderColor = System.Drawing.Color.Navy;
            this.lineCI.Name = "lineCI";
            this.lineCI.X1 = 203;
            this.lineCI.X2 = 383;
            this.lineCI.Y1 = 34;
            this.lineCI.Y2 = 34;
            // 
            // lineShapeTEA
            // 
            this.lineShapeTEA.BorderColor = System.Drawing.Color.Navy;
            this.lineShapeTEA.Name = "lineShapeTEA";
            this.lineShapeTEA.X1 = 1063;
            this.lineShapeTEA.X2 = 1079;
            this.lineShapeTEA.Y1 = 446;
            this.lineShapeTEA.Y2 = 439;
            // 
            // lineShapeVariacionPorcentual
            // 
            this.lineShapeVariacionPorcentual.BorderColor = System.Drawing.Color.Navy;
            this.lineShapeVariacionPorcentual.Name = "lineShapeVariacionPorcentual";
            this.lineShapeVariacionPorcentual.X1 = 1067;
            this.lineShapeVariacionPorcentual.X2 = 1060;
            this.lineShapeVariacionPorcentual.Y1 = 648;
            this.lineShapeVariacionPorcentual.Y2 = 645;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShapeTEA,
            this.lineShapeVariacionPorcentual});
            this.shapeContainer1.Size = new System.Drawing.Size(1063, 886);
            this.shapeContainer1.TabIndex = 75;
            this.shapeContainer1.TabStop = false;
            // 
            // Anualidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1063, 886);
            this.Controls.Add(this.panelFormula);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Anualidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Anualidades_Load);
            this.panelFormula.ResumeLayout(false);
            this.panelFormula.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormula;
        private System.Windows.Forms.Label lblResultadoFormula;
        private System.Windows.Forms.Label lblResultFormula;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCalcular;
        private System.Windows.Forms.Label lblCalcular;
        private System.Windows.Forms.Label lblCapitalInicial;
        private System.Windows.Forms.Label lblTipoInteres;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox txtPrimeraCuota;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.Label lblPorcentajeTI;
        private System.Windows.Forms.TextBox txtTipoInteres;
        private System.Windows.Forms.ComboBox cmbTiempo;
        private System.Windows.Forms.Label lblDolarCI;
        private System.Windows.Forms.Panel panel4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineCF;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineTiempo;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineTI;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineCI;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShapeTEA;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShapeVariacionPorcentual;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}