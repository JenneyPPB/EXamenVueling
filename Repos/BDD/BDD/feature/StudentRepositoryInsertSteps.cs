using System;
using TechTalk.SpecFlow;

namespace FileServer.Infraestructure.Repository.BDDTests.feature
{
    [Binding]
    public class StudentRepositoryInsertSteps
    {
        protected StudentRepository repository = new StudentRepository();
        protected Student student;

        [Given(@"I have a new student without Id")]
        public void GivenIHaveANewStudentWithoutId()
        {
            student = new Student(new DateTime(1990, 6, 22));
        }
        
        [When(@"I run the method Insert of student Repository")]
        public void WhenIRunTheMethodInsertOfStudentRepository()
        {
            repository.Insert(student);
        }
        
        [Then(@"the Student Repository should return an student with Id")]
        public void ThenTheStudentRepositoryShouldReturnAnStudentWithId()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
