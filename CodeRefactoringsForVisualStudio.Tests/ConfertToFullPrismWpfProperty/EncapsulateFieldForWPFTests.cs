using ConvertToFullPrismWpfProperty;
using Microsoft.CodeAnalysis.CodeRefactorings;
using NUnit.Framework;

namespace CodeRefactoringsForVisualStudio.Tests.ConfertToFullPrismWpfProperty
{
    public class EncapsulateFieldForWPFTests : BaseCodeRefactoringTestFixture
    {
        protected override CodeRefactoringProvider CreateProvider()
        {
            return new ConvertToFullPrismWpfPropertyRefactoringProvider();
        }


       
        [TestCase("ShouldCreateFullProperty")]
        public void Should(string caseName)
        {
            TestCodeRefactoring("ConfertToFullPrismWpfProperty.Data", caseName);
        }
    }
}
