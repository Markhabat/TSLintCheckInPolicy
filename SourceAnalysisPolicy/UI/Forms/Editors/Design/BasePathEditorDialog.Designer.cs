﻿// <auto-generated />
namespace RalphJansen.StyleCopCheckInPolicy.UI.Forms.Editors.Design
{
    partial class BasePathEditorDialog
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
            this.ExclusionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ExclusionTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExclusionTypeComboBox
            // 
            this.ExclusionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExclusionTypeComboBox.FormattingEnabled = true;
            this.ExclusionTypeComboBox.Location = new System.Drawing.Point(98, 22);
            this.ExclusionTypeComboBox.Name = "ExclusionTypeComboBox";
            this.ExclusionTypeComboBox.Size = new System.Drawing.Size(169, 21);
            this.ExclusionTypeComboBox.TabIndex = 1007;
            // 
            // ExclusionTypeLabel
            // 
            this.ExclusionTypeLabel.AutoSize = true;
            this.ExclusionTypeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExclusionTypeLabel.Location = new System.Drawing.Point(12, 25);
            this.ExclusionTypeLabel.Name = "ExclusionTypeLabel";
            this.ExclusionTypeLabel.Size = new System.Drawing.Size(80, 13);
            this.ExclusionTypeLabel.TabIndex = 1006;
            this.ExclusionTypeLabel.Text = "Exclusion type:";
            // 
            // BasePathEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ExclusionTypeComboBox);
            this.Controls.Add(this.ExclusionTypeLabel);
            this.Name = "BasePathEditorDialog";
            this.Load += new System.EventHandler(this.BasePathEditorDialog_Load);
            this.Controls.SetChildIndex(this.AbortButton, 0);
            this.Controls.SetChildIndex(this.SubmitButton, 0);
            this.Controls.SetChildIndex(this.ExclusionTypeLabel, 0);
            this.Controls.SetChildIndex(this.ExclusionTypeComboBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ComboBox ExclusionTypeComboBox;
        protected System.Windows.Forms.Label ExclusionTypeLabel;

    }
}