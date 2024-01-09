namespace MorseTranslate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTranslate = new Button();
            mainLanguage = new ComboBox();
            resultLanguage = new ComboBox();
            inputText = new TextBox();
            outputText = new TextBox();
            textForInput = new Label();
            textForResult = new Label();
            BClear = new Button();
            BChangePlaces = new Button();
            LStatusOfTranslate = new Label();
            BCopy = new Button();
            SuspendLayout();
            // 
            // BTranslate
            // 
            BTranslate.Location = new Point(370, 374);
            BTranslate.Name = "BTranslate";
            BTranslate.Size = new Size(273, 127);
            BTranslate.TabIndex = 0;
            BTranslate.Text = "Translate";
            BTranslate.UseVisualStyleBackColor = true;
            BTranslate.Click += BTranslate_Click;
            // 
            // mainLanguage
            // 
            mainLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            mainLanguage.FormattingEnabled = true;
            mainLanguage.Items.AddRange(new object[] { "English", "Morse" });
            mainLanguage.Location = new Point(107, 374);
            mainLanguage.Name = "mainLanguage";
            mainLanguage.Size = new Size(122, 23);
            mainLanguage.TabIndex = 3;
            // 
            // resultLanguage
            // 
            resultLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            resultLanguage.FormattingEnabled = true;
            resultLanguage.Items.AddRange(new object[] { "Morse", "English" });
            resultLanguage.Location = new Point(761, 374);
            resultLanguage.Name = "resultLanguage";
            resultLanguage.Size = new Size(121, 23);
            resultLanguage.TabIndex = 4;
            // 
            // inputText
            // 
            inputText.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            inputText.Location = new Point(47, 212);
            inputText.Multiline = true;
            inputText.Name = "inputText";
            inputText.Size = new Size(258, 110);
            inputText.TabIndex = 5;
            inputText.TextChanged += inputText_TextChanged;
            // 
            // outputText
            // 
            outputText.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            outputText.Location = new Point(699, 212);
            outputText.Multiline = true;
            outputText.Name = "outputText";
            outputText.Size = new Size(263, 110);
            outputText.TabIndex = 6;
            outputText.TextChanged += outputText_TextChanged;
            // 
            // textForInput
            // 
            textForInput.AutoSize = true;
            textForInput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textForInput.Location = new Point(124, 119);
            textForInput.Name = "textForInput";
            textForInput.Size = new Size(69, 32);
            textForInput.TabIndex = 7;
            textForInput.Text = "Enter";
            textForInput.Click += textForInput_Click;
            // 
            // textForResult
            // 
            textForResult.AutoSize = true;
            textForResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textForResult.Location = new Point(794, 119);
            textForResult.Name = "textForResult";
            textForResult.Size = new Size(78, 32);
            textForResult.TabIndex = 8;
            textForResult.Text = "Result";
            // 
            // BClear
            // 
            BClear.Location = new Point(261, 404);
            BClear.Name = "BClear";
            BClear.Size = new Size(94, 66);
            BClear.TabIndex = 9;
            BClear.Text = "Clear";
            BClear.UseVisualStyleBackColor = true;
            BClear.Click += BClear_Click;
            // 
            // BChangePlaces
            // 
            BChangePlaces.Location = new Point(434, 282);
            BChangePlaces.Name = "BChangePlaces";
            BChangePlaces.Size = new Size(134, 40);
            BChangePlaces.TabIndex = 10;
            BChangePlaces.Text = "change language";
            BChangePlaces.UseVisualStyleBackColor = true;
            BChangePlaces.Click += BChangePlaces_Click;
            // 
            // LStatusOfTranslate
            // 
            LStatusOfTranslate.AutoSize = true;
            LStatusOfTranslate.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LStatusOfTranslate.Location = new Point(355, 230);
            LStatusOfTranslate.Name = "LStatusOfTranslate";
            LStatusOfTranslate.Size = new Size(0, 37);
            LStatusOfTranslate.TabIndex = 11;
            LStatusOfTranslate.Click += LStatusOfTranslate_Click;
            // 
            // BCopy
            // 
            BCopy.Location = new Point(794, 328);
            BCopy.Name = "BCopy";
            BCopy.Size = new Size(75, 23);
            BCopy.TabIndex = 12;
            BCopy.Text = "Copy text";
            BCopy.UseVisualStyleBackColor = true;
            BCopy.Click += BCopy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1015, 524);
            Controls.Add(BCopy);
            Controls.Add(LStatusOfTranslate);
            Controls.Add(BChangePlaces);
            Controls.Add(BClear);
            Controls.Add(textForResult);
            Controls.Add(textForInput);
            Controls.Add(outputText);
            Controls.Add(inputText);
            Controls.Add(resultLanguage);
            Controls.Add(mainLanguage);
            Controls.Add(BTranslate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTranslate;
        private ComboBox mainLanguage;
        private ComboBox resultLanguage;
        private TextBox inputText;
        private TextBox outputText;
        private Label textForInput;
        private Label textForResult;
        private Button BClear;
        private Button BChangePlaces;
        private Label LStatusOfTranslate;
        private Button BCopy;
    }
}