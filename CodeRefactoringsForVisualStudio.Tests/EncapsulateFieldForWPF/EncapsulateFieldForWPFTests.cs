using EncapsulateFieldForWPF;
using Microsoft.CodeAnalysis.CodeRefactorings;
using NUnit.Framework;

namespace CodeRefactoringsForVisualStudio.Tests.EncapsulateFieldForWPF
{
    public class EncapsulateFieldForWPFTests : BaseCodeRefactoringTestFixture
    {
        protected override CodeRefactoringProvider CreateProvider()
        {
            return new EncapsulateFieldForWPFRefactoringProvider();
        }


       
        [TestCase("ShouldEncapsulateFieldWhenCursorIsInTheMiddle")]
        [TestCase("ShouldEncapsulateFieldWhenCursorIsOnIdentifier")]
        [TestCase("ShouldEncapsulateFieldWhenCursorIsOnTypeName")]
        [TestCase("ShouldEncapsulateFieldWhenWholeFieldDeclarationIsSelected")]  
        [TestCase("ShouldEncapsulateTwoFieldsWhenTwoFieldsAreInLine")]
        [TestCase("ShouldEncapsulateTwoFieldsWhenTwoFieldsAreSelected")]
        public void Should(string caseName)
        {
            TestCodeRefactoring("EncapsulateFieldForWPF.Data", caseName);
        }
    }
}
