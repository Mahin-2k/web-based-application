using Autofac.Extras.Moq;
using DigiCV.Application;
using DigiCV.Application.Features.Training.Repositories;
using DigiCV.Application.Features.Training.Services;
using DigiCV.Domain.Entities;
using DigiCV.Infrastructure.Features.Services;
using Moq;
using Shouldly;

namespace DigiCV.Infrastructure.Tests;

public class ResumeServiceTests
{
    private AutoMock _mock;
    private Mock<IApplicationUnitOfWork> _applicationUnitOfWork;
    private Mock<IResumeRepository> _resumeRepositoryMock;
    private IResumeService _resumeService;
    
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        _mock = AutoMock.GetLoose();
    }

    [SetUp]
    public void Setup()
    {
        _applicationUnitOfWork = _mock.Mock<IApplicationUnitOfWork>();
        _resumeRepositoryMock = _mock.Mock<IResumeRepository>();
        _resumeService = _mock.Create<ResumeService>();
    }

    [TearDown]
    public void Teardown()
    {
        _applicationUnitOfWork.Reset();
        _resumeRepositoryMock.Reset();
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        _mock?.Dispose();
    }
    
    [Test]
    public void CreateResume()
    {
        // Arrange
        Resume resume = new Resume()
        {
            Id = new Guid(),
            UserId = new Guid(),
            ResumeTemplateId = new Guid(),
            Title = "New Resume Title",
            ImageName = "MyPhoto.Jpg",
            FullName = "ABRU",
            Email = "abdru@gmail.com",
            PhoneNumber = "018********",
            Skype = "abru.skype",
            LinkedIn = "abru.linkden",
            Address = "Noakhali",
            Summary = "Nil",
            Trainings = new List<string>{"Dev Skill","MIU"},
            Experiences = new List<Experience>
            {
                new Experience
                {
                    Position = "Executive",
                    Companay = "Smart Tech",
                    JoiningDate = DateTime.Now,
                    ResignationDate = DateTime.Now
                }
            },
            Educations = new List<Education>
            {
                new Education
                {
                    University = "Demo",
                    Grade = "D",
                    PassingYear = DateTime.Today
                }
            },
            Projects = new List<Project>
            {
                new Project
                {
                    Name = "DigiCv",
                    Author = "Self"
                }
            },
            References = new List<Reference>
            {
                new Reference
                {
                    Name = "Abdullah",
                    PhoneNumber = "017******",
                    Compnay = "Demo Company"
                }
            }
        };
        
        _applicationUnitOfWork.Setup(x => x.Resumes)
            .Returns(_resumeRepositoryMock.Object);

        _applicationUnitOfWork.Setup(x => x.SaveAsync()).Verifiable();
        
        // Act
        _resumeService.CreateResume(resume);

        // Assert
        this.ShouldSatisfyAllConditions(_applicationUnitOfWork.VerifyAll,
            _resumeRepositoryMock.VerifyAll);

    }
}