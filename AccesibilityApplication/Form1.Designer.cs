namespace AccesibilityApplication
{
    partial class OrdenDePedido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            Microsoft.Win32.SystemEvents.UserPreferenceChanged
               -= new Microsoft.Win32.UserPreferenceChangedEventHandler(
               this.UserPreferenceChanged);
            base.Dispose(disposing);
        }
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenDePedido));
            this.logo = new System.Windows.Forms.PictureBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.costumerName = new System.Windows.Forms.TextBox();
            this.sizeOptions = new System.Windows.Forms.GroupBox();
            this.largePizza = new System.Windows.Forms.RadioButton();
            this.smallPizza = new System.Windows.Forms.RadioButton();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.toppings = new System.Windows.Forms.CheckedListBox();
            this.order = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.theMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.sizeOptions.SuspendLayout();
            this.theMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.AccessibleDescription = "Una porción de pizza";
            this.logo.AccessibleName = "Logotipo de la compañía";
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(89, 55);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(82, 68);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // companyLabel
            // 
            this.companyLabel.AccessibleDescription = "Nombre de la compañía";
            this.companyLabel.AccessibleName = "Nombre de la compañía";
            this.companyLabel.AutoSize = true;
            this.companyLabel.BackColor = System.Drawing.Color.Blue;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.Yellow;
            this.companyLabel.Location = new System.Drawing.Point(275, 75);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(157, 29);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "GOOD PIZZA";
            // 
            // customerLabel
            // 
            this.customerLabel.AccessibleDescription = "Etiqueta de nombre del cliente";
            this.customerLabel.AccessibleName = "Etiqueta de nombre del cliente";
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(268, 125);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(58, 17);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "&Nombre";
            // 
            // costumerName
            // 
            this.costumerName.AccessibleDescription = "Nombre del cliente";
            this.costumerName.AccessibleName = "Nombre del cliente";
            this.costumerName.Location = new System.Drawing.Point(332, 125);
            this.costumerName.Name = "costumerName";
            this.costumerName.Size = new System.Drawing.Size(116, 23);
            this.costumerName.TabIndex = 3;
            // 
            // sizeOptions
            // 
            this.sizeOptions.AccessibleDescription = "Opciones de tamaño de pizza";
            this.sizeOptions.AccessibleName = "Opciones de tamaño de pizza";
            this.sizeOptions.Controls.Add(this.largePizza);
            this.sizeOptions.Controls.Add(this.smallPizza);
            this.sizeOptions.Location = new System.Drawing.Point(60, 154);
            this.sizeOptions.Name = "sizeOptions";
            this.sizeOptions.Size = new System.Drawing.Size(165, 100);
            this.sizeOptions.TabIndex = 4;
            this.sizeOptions.TabStop = false;
            this.sizeOptions.Text = "Tamaño de la pizza";
            // 
            // largePizza
            // 
            this.largePizza.AccessibleDescription = "Pizza grande";
            this.largePizza.AccessibleName = "Pizza grande";
            this.largePizza.AutoSize = true;
            this.largePizza.Location = new System.Drawing.Point(20, 57);
            this.largePizza.Name = "largePizza";
            this.largePizza.Size = new System.Drawing.Size(122, 21);
            this.largePizza.TabIndex = 1;
            this.largePizza.TabStop = true;
            this.largePizza.Text = "&Grande 10.00€";
            this.largePizza.UseVisualStyleBackColor = true;
            // 
            // smallPizza
            // 
            this.smallPizza.AccessibleDescription = "Pizza pequeña";
            this.smallPizza.AccessibleName = "Pizza pequeña";
            this.smallPizza.AutoSize = true;
            this.smallPizza.Checked = true;
            this.smallPizza.Location = new System.Drawing.Point(19, 22);
            this.smallPizza.Name = "smallPizza";
            this.smallPizza.Size = new System.Drawing.Size(123, 21);
            this.smallPizza.TabIndex = 0;
            this.smallPizza.TabStop = true;
            this.smallPizza.Text = "&Pequeña 6.00€";
            this.smallPizza.UseVisualStyleBackColor = true;
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AccessibleDescription = "Etiqueta de toppings";
            this.toppingsLabel.AccessibleName = "Etiqueta de toppings";
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Location = new System.Drawing.Point(268, 154);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(180, 17);
            this.toppingsLabel.TabIndex = 5;
            this.toppingsLabel.Text = "&Toppings (0.75€ cada uno)";
            // 
            // toppings
            // 
            this.toppings.AccessibleDescription = "Toppings disponibles";
            this.toppings.AccessibleName = "Toppings disponibles";
            this.toppings.FormattingEnabled = true;
            this.toppings.Items.AddRange(new object[] {
            "Alejandro Arrabal",
            "Eduardo Guerra",
            "Alberto"});
            this.toppings.Location = new System.Drawing.Point(271, 176);
            this.toppings.Name = "toppings";
            this.toppings.Size = new System.Drawing.Size(177, 76);
            this.toppings.TabIndex = 6;
            // 
            // order
            // 
            this.order.AccessibleDescription = "Terminar el pedido";
            this.order.AccessibleName = "Terminar el pedido";
            this.order.Location = new System.Drawing.Point(292, 289);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(118, 34);
            this.order.TabIndex = 7;
            this.order.Text = "&Pedir";
            this.order.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.AccessibleDescription = "Cancelar el pedido";
            this.cancel.AccessibleName = "Cancelar pedido";
            this.cancel.Location = new System.Drawing.Point(84, 289);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(118, 34);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "&Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // theMainMenu
            // 
            this.theMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCommands});
            this.theMainMenu.Location = new System.Drawing.Point(0, 0);
            this.theMainMenu.Name = "theMainMenu";
            this.theMainMenu.Size = new System.Drawing.Size(497, 24);
            this.theMainMenu.TabIndex = 9;
            this.theMainMenu.Text = "menuStrip1";
            // 
            // fileCommands
            // 
            this.fileCommands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitApp});
            this.fileCommands.Name = "fileCommands";
            this.fileCommands.Size = new System.Drawing.Size(60, 20);
            this.fileCommands.Text = "&Archivo";
            // 
            // exitApp
            // 
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(181, 22);
            this.exitApp.Text = "&Salir de la aplicación";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Formulario de pedido de pizzas";
            this.notifyIcon.Visible = true;
            // 
            // OrdenDePedido
            // 
            this.AccessibleDescription = "Form de pedido";
            this.AccessibleName = "Form de pedido";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 364);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.order);
            this.Controls.Add(this.toppings);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.sizeOptions);
            this.Controls.Add(this.costumerName);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.theMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.theMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrdenDePedido";
            this.Text = "Formulario de pedidos de pizza: Ángel Álvarez Rodríguez";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.sizeOptions.ResumeLayout(false);
            this.sizeOptions.PerformLayout();
            this.theMainMenu.ResumeLayout(false);
            this.theMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox costumerName;
        private System.Windows.Forms.GroupBox sizeOptions;
        private System.Windows.Forms.RadioButton largePizza;
        private System.Windows.Forms.RadioButton smallPizza;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.CheckedListBox toppings;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.MenuStrip theMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileCommands;
        private System.Windows.Forms.ToolStripMenuItem exitApp;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

