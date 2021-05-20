using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Burak_CoreEntityCodeFirst.Entity
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }

    //https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key#many-to-many
    // Many to many iliskisi boyle yapiliyor. MapLeftKey ve MapRightKey yok. UsingEntity composite table'i hallediyor.
    public class CourseMap : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder
                .HasMany(course => course.Students)
                .WithMany(student => student.Courses)
                .UsingEntity(j => j.ToTable("CoursesStudents"));
        }
    }
}