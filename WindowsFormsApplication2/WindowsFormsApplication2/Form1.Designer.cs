namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.memory = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.operation_division = new System.Windows.Forms.Button();
            this.operation_sqrt = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.operation_multiplication = new System.Windows.Forms.Button();
            this.operation_procent = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.operation_minus = new System.Windows.Forms.Button();
            this.operation_delitnax = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.operation_plus = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.tab10 = new System.Windows.Forms.Button();
            this.tab11 = new System.Windows.Forms.Button();
            this.tab0 = new System.Windows.Forms.Button();
            this.tab2 = new System.Windows.Forms.Button();
            this.tab3 = new System.Windows.Forms.Button();
            this.tab1 = new System.Windows.Forms.Button();
            this.tab5 = new System.Windows.Forms.Button();
            this.tab6 = new System.Windows.Forms.Button();
            this.tab4 = new System.Windows.Forms.Button();
            this.tab8 = new System.Windows.Forms.Button();
            this.tab9 = new System.Windows.Forms.Button();
            this.tab7 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // memory
            // 
            this.memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memory.Location = new System.Drawing.Point(364, 104);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(50, 30);
            this.memory.TabIndex = 20;
            this.memory.UseVisualStyleBackColor = true;
            this.memory.Click += new System.EventHandler(this.memory_click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.Color.Red;
            this.back.Location = new System.Drawing.Point(155, 104);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 30);
            this.back.TabIndex = 21;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.clear_click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CE.ForeColor = System.Drawing.Color.Red;
            this.CE.Location = new System.Drawing.Point(82, 104);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(50, 30);
            this.CE.TabIndex = 22;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.clear_click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C.ForeColor = System.Drawing.Color.Red;
            this.C.Location = new System.Drawing.Point(14, 104);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(50, 30);
            this.C.TabIndex = 23;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.clear_click);
            // 
            // operation_division
            // 
            this.operation_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.operation_division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.operation_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation_division.ForeColor = System.Drawing.Color.Red;
            this.operation_division.Location = new System.Drawing.Point(301, 145);
            this.operation_division.Name = "operation_division";
            this.operation_division.Size = new System.Drawing.Size(50, 30);
            this.operation_division.TabIndex = 12;
            this.operation_division.Text = "/";
            this.operation_division.UseVisualStyleBackColor = false;
            this.operation_division.Click += new System.EventHandler(this.operation_click);
            // 
            // operation_sqrt
            // 
            this.operation_sqrt.BackColor = System.Drawing.Color.Silver;
            this.operation_sqrt.Cursor = System.Windows.Forms.Cursors.Cross;
            this.operation_sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation_sqrt.Location = new System.Drawing.Point(364, 145);
            this.operation_sqrt.Name = "operation_sqrt";
            this.operation_sqrt.Size = new System.Drawing.Size(50, 30);
            this.operation_sqrt.TabIndex = 19;
            this.operation_sqrt.Text = "sqrt";
            this.operation_sqrt.UseVisualStyleBackColor = false;
            this.operation_sqrt.Click += new System.EventHandler(this.resultoper_click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.Location = new System.Drawing.Point(14, 149);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 30);
            this.button18.TabIndex = 25;
            this.button18.Text = "MC";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.memory_click);
            // 
            // operation_multiplication
            // 
            this.operation_multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.operation_multiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.operation_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation_multiplication.ForeColor = System.Drawing.Color.Red;
            this.operation_multiplication.Location = new System.Drawing.Point(301, 185);
            this.operation_multiplication.Name = "operation_multiplication";
            this.operation_multiplication.Size = new System.Drawing.Size(50, 30);
            this.operation_multiplication.TabIndex = 13;
            this.operation_multiplication.Text = "*";
            this.operation_multiplication.UseVisualStyleBackColor = false;
            this.operation_multiplication.Click += new System.EventHandler(this.operation_click);
            // 
            // operation_procent
            // 
            this.operation_procent.BackColor = System.Drawing.Color.Silver;
            this.operation_procent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation_procent.Location = new System.Drawing.Point(364, 185);
            this.operation_procent.Name = "operation_procent";
            this.operation_procent.Size = new System.Drawing.Size(50, 30);
            this.operation_procent.TabIndex = 18;
            this.operation_procent.Text = "%";
            this.operation_procent.UseVisualStyleBackColor = false;
            this.operation_procent.Click += new System.EventHandler(this.resultoper_click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.Location = new System.Drawing.Point(14, 185);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(50, 30);
            this.button24.TabIndex = 24;
            this.button24.Text = "MR";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.memory_click);
            // 
            // operation_minus
            // 
            this.operation_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.operation_minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.operation_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation_minus.ForeColor = System.Drawing.Color.Red;
            this.operation_minus.Location = new System.Drawing.Point(301, 221);
            this.operation_minus.Name = "operation_minus";
            this.operation_minus.Size = new System.Drawing.Size(50, 30);
            this.operation_minus.TabIndex = 14;
            this.operation_minus.Text = "-";
            this.operation_minus.UseVisualStyleBackColor = false;
            this.operation_minus.Click += new System.EventHandler(this.operation_click);
            // 
            // operation_delitnax
            // 
            this.operation_delitnax.BackColor = System.Drawing.Color.Silver;
            this.operation_delitnax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation_delitnax.Location = new System.Drawing.Point(364, 221);
            this.operation_delitnax.Name = "operation_delitnax";
            this.operation_delitnax.Size = new System.Drawing.Size(50, 30);
            this.operation_delitnax.TabIndex = 17;
            this.operation_delitnax.Text = "1/x";
            this.operation_delitnax.UseVisualStyleBackColor = false;
            this.operation_delitnax.Click += new System.EventHandler(this.resultoper_click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button30.Location = new System.Drawing.Point(14, 221);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(50, 30);
            this.button30.TabIndex = 26;
            this.button30.Text = "MS";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.memory_click);
            // 
            // operation_plus
            // 
            this.operation_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.operation_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.operation_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation_plus.ForeColor = System.Drawing.Color.Red;
            this.operation_plus.Location = new System.Drawing.Point(301, 257);
            this.operation_plus.Name = "operation_plus";
            this.operation_plus.Size = new System.Drawing.Size(50, 30);
            this.operation_plus.TabIndex = 15;
            this.operation_plus.Text = "+";
            this.operation_plus.UseVisualStyleBackColor = false;
            this.operation_plus.Click += new System.EventHandler(this.operation_click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Yellow;
            this.result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.Red;
            this.result.Location = new System.Drawing.Point(364, 257);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(50, 30);
            this.result.TabIndex = 16;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.result_click);
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button36.Location = new System.Drawing.Point(14, 257);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(50, 30);
            this.button36.TabIndex = 27;
            this.button36.Text = "M+";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.memory_click);
            // 
            // tab10
            // 
            this.tab10.AutoEllipsis = true;
            this.tab10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tab10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab10.ForeColor = System.Drawing.Color.Indigo;
            this.tab10.Location = new System.Drawing.Point(155, 257);
            this.tab10.Name = "tab10";
            this.tab10.Size = new System.Drawing.Size(50, 30);
            this.tab10.TabIndex = 28;
            this.tab10.Text = "+/-";
            this.tab10.UseVisualStyleBackColor = false;
            this.tab10.Click += new System.EventHandler(this.tab_click);
            // 
            // tab11
            // 
            this.tab11.AutoEllipsis = true;
            this.tab11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tab11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab11.ForeColor = System.Drawing.Color.Indigo;
            this.tab11.Location = new System.Drawing.Point(229, 257);
            this.tab11.Name = "tab11";
            this.tab11.Size = new System.Drawing.Size(50, 30);
            this.tab11.TabIndex = 29;
            this.tab11.Text = ".";
            this.tab11.UseVisualStyleBackColor = false;
            this.tab11.Click += new System.EventHandler(this.tab_click);
            // 
            // tab0
            // 
            this.tab0.AutoEllipsis = true;
            this.tab0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tab0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab0.ForeColor = System.Drawing.Color.Indigo;
            this.tab0.Location = new System.Drawing.Point(82, 257);
            this.tab0.Name = "tab0";
            this.tab0.Size = new System.Drawing.Size(50, 30);
            this.tab0.TabIndex = 1;
            this.tab0.Text = "0";
            this.tab0.UseVisualStyleBackColor = false;
            this.tab0.Click += new System.EventHandler(this.tab_click);
            // 
            // tab2
            // 
            this.tab2.AutoEllipsis = true;
            this.tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab2.ForeColor = System.Drawing.Color.Indigo;
            this.tab2.Location = new System.Drawing.Point(155, 221);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(50, 30);
            this.tab2.TabIndex = 3;
            this.tab2.Text = "2";
            this.tab2.UseVisualStyleBackColor = false;
            this.tab2.Click += new System.EventHandler(this.tab_click);
            // 
            // tab3
            // 
            this.tab3.AutoEllipsis = true;
            this.tab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab3.ForeColor = System.Drawing.Color.Indigo;
            this.tab3.Location = new System.Drawing.Point(229, 221);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(50, 30);
            this.tab3.TabIndex = 4;
            this.tab3.Text = "3";
            this.tab3.UseVisualStyleBackColor = false;
            this.tab3.Click += new System.EventHandler(this.tab_click);
            // 
            // tab1
            // 
            this.tab1.AutoEllipsis = true;
            this.tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab1.ForeColor = System.Drawing.Color.Indigo;
            this.tab1.Location = new System.Drawing.Point(82, 221);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(50, 30);
            this.tab1.TabIndex = 2;
            this.tab1.Text = "1";
            this.tab1.UseVisualStyleBackColor = false;
            this.tab1.Click += new System.EventHandler(this.tab_click);
            // 
            // tab5
            // 
            this.tab5.AutoEllipsis = true;
            this.tab5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tab5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab5.ForeColor = System.Drawing.Color.Indigo;
            this.tab5.Location = new System.Drawing.Point(155, 185);
            this.tab5.Name = "tab5";
            this.tab5.Size = new System.Drawing.Size(50, 30);
            this.tab5.TabIndex = 6;
            this.tab5.Text = "5";
            this.tab5.UseVisualStyleBackColor = false;
            this.tab5.Click += new System.EventHandler(this.tab_click);
            // 
            // tab6
            // 
            this.tab6.AutoEllipsis = true;
            this.tab6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab6.ForeColor = System.Drawing.Color.Indigo;
            this.tab6.Location = new System.Drawing.Point(229, 185);
            this.tab6.Name = "tab6";
            this.tab6.Size = new System.Drawing.Size(50, 30);
            this.tab6.TabIndex = 7;
            this.tab6.Text = "6";
            this.tab6.UseVisualStyleBackColor = false;
            this.tab6.Click += new System.EventHandler(this.tab_click);
            // 
            // tab4
            // 
            this.tab4.AutoEllipsis = true;
            this.tab4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab4.ForeColor = System.Drawing.Color.Indigo;
            this.tab4.Location = new System.Drawing.Point(82, 185);
            this.tab4.Name = "tab4";
            this.tab4.Size = new System.Drawing.Size(50, 30);
            this.tab4.TabIndex = 5;
            this.tab4.Text = "4";
            this.tab4.UseVisualStyleBackColor = false;
            this.tab4.Click += new System.EventHandler(this.tab_click);
            // 
            // tab8
            // 
            this.tab8.AutoEllipsis = true;
            this.tab8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tab8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab8.ForeColor = System.Drawing.Color.Indigo;
            this.tab8.Location = new System.Drawing.Point(155, 145);
            this.tab8.Name = "tab8";
            this.tab8.Size = new System.Drawing.Size(50, 30);
            this.tab8.TabIndex = 9;
            this.tab8.Text = "8";
            this.tab8.UseVisualStyleBackColor = false;
            this.tab8.Click += new System.EventHandler(this.tab_click);
            // 
            // tab9
            // 
            this.tab9.AutoEllipsis = true;
            this.tab9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tab9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab9.ForeColor = System.Drawing.Color.Indigo;
            this.tab9.Location = new System.Drawing.Point(229, 145);
            this.tab9.Name = "tab9";
            this.tab9.Size = new System.Drawing.Size(50, 30);
            this.tab9.TabIndex = 10;
            this.tab9.Text = "9";
            this.tab9.UseVisualStyleBackColor = false;
            this.tab9.Click += new System.EventHandler(this.tab_click);
            // 
            // tab7
            // 
            this.tab7.AutoEllipsis = true;
            this.tab7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tab7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab7.ForeColor = System.Drawing.Color.Indigo;
            this.tab7.Location = new System.Drawing.Point(82, 145);
            this.tab7.Name = "tab7";
            this.tab7.Size = new System.Drawing.Size(50, 30);
            this.tab7.TabIndex = 8;
            this.tab7.Text = "7";
            this.tab7.UseVisualStyleBackColor = false;
            this.tab7.Click += new System.EventHandler(this.tab_click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(14, 55);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(400, 20);
            this.display.TabIndex = 11;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.Click += new System.EventHandler(this.display_click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(318, 13);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Edit                    View                                       Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(469, 331);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.operation_plus);
            this.Controls.Add(this.result);
            this.Controls.Add(this.tab10);
            this.Controls.Add(this.tab11);
            this.Controls.Add(this.tab0);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.operation_minus);
            this.Controls.Add(this.operation_delitnax);
            this.Controls.Add(this.tab2);
            this.Controls.Add(this.tab3);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.operation_multiplication);
            this.Controls.Add(this.operation_procent);
            this.Controls.Add(this.tab5);
            this.Controls.Add(this.tab6);
            this.Controls.Add(this.tab4);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.operation_division);
            this.Controls.Add(this.operation_sqrt);
            this.Controls.Add(this.tab8);
            this.Controls.Add(this.tab9);
            this.Controls.Add(this.tab7);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.back);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.C);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Location = new System.Drawing.Point(10, 20);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button memory;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button operation_division;
        private System.Windows.Forms.Button operation_sqrt;
        private System.Windows.Forms.Button tab8;
        private System.Windows.Forms.Button tab9;
        private System.Windows.Forms.Button tab7;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button operation_multiplication;
        private System.Windows.Forms.Button operation_procent;
        private System.Windows.Forms.Button tab5;
        private System.Windows.Forms.Button tab6;
        private System.Windows.Forms.Button tab4;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button operation_minus;
        private System.Windows.Forms.Button operation_delitnax;
        private System.Windows.Forms.Button tab2;
        private System.Windows.Forms.Button tab3;
        private System.Windows.Forms.Button tab1;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button operation_plus;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button tab10;
        private System.Windows.Forms.Button tab11;
        private System.Windows.Forms.Button tab0;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

