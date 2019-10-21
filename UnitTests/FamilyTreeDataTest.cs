using FamilyTree.ApplicationCore.Enums;
using FamilyTree.ApplicationCore.Interfaces;
using FamilyTree.Data.Data;
using Moq;
using System.Linq;
using Xunit;

namespace UnitTests
{
    public class FamilyTreeDataTest
    {
        private Mock<IFamilyTreeRepository> _mockFamilyTreeRepository;

        [Fact]
        public void Should_GetAllPersons()
        {
            //Arrange
            var inMemoryFamilyTreeData = new InMemoryFamilyTreeRepository();

            //Act
            var persons = inMemoryFamilyTreeData.GetAllPersons();

            //Assert
            Assert.True(persons.Count() > 0);
        }

        [Fact]
        public void Should_GetAllChildren()
        {
            //Arrange
            var inMemoryFamilyTreeData = new InMemoryFamilyTreeRepository();

            //Act
            var children = inMemoryFamilyTreeData.GetChildren();

            //Assert
            Assert.True(children.Count() > 0);
        }

        [Fact]
        public void Should_GetChildByProvidedPersonId()
        {
            //Arrange
            var personId = 2;
            var actual = 5;
            var inMemoryFamilyTreeData = new InMemoryFamilyTreeRepository();

            //Act
            var child = inMemoryFamilyTreeData.GetChildByPersonId(personId);

            //Assert
            Assert.Equal(child.FatherId, actual);
        }

        
        [Fact]
        public void Should_GetPersonByProvidedId()
        {
            //Arrange
            var Id = 7;
            var actual = "Luke";
            var inMemoryFamilyTreeData = new InMemoryFamilyTreeRepository();

            //Act
            var person = inMemoryFamilyTreeData.GetPersonById(Id);

            //Assert
            Assert.Equal(person.Name, actual);
        }

        [Fact]
        public void Should_GetParentByPersonId()
        {
            //Arrange
            var Id = 1;
            var actual = LivingStatus.Dead;
            var inMemoryFamilyTreeData = new InMemoryFamilyTreeRepository();

            //Act
            var parent = inMemoryFamilyTreeData.GetParentById(Id);
            
            //Assert
            Assert.Equal(parent.LivingStatus, actual);
        }
    }
}
