using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRefactoringsForVisualStudio.Tests.ConfertToFullPrismWpfProperty.Data
{
    class ShouldCreateFullProperty
    {
        private string someProperty;

        public string SomeProperty
        {
            get
            {
                return someProperty;
            }

            set
            {
                SetProperty(ref someProperty, value);
            }
        }
    }
}