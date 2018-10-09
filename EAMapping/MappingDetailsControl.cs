﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MP = MappingFramework;

namespace EAMapping
{
    public partial class MappingDetailsControl : UserControl
    {
        public MappingDetailsControl()
        {
            InitializeComponent();
        }
        private void loadContent()
        {
            this.fromTextBox.Text = this._mapping?.source?.name;
            this.toTextBox.Text = this._mapping?.target?.name;
            this.mappingLogicTextBox.Text = this._mapping?.mappingLogic?.description;
        }
        private void unloadContent()
        {
            if (this._mapping?.mappingLogic != null)
                this._mapping.mappingLogic.description = this.mappingLogicTextBox.Text; 
            //TODO: create mapping logic if not present?
        }
        private MP.Mapping _mapping;
        public MP.Mapping mapping
        {
            get
            {
                return this._mapping;
            }
            set
            {
                this._mapping = value;
                this.loadContent();
            }
        }
    }
}
