using Business.Concrete;
using DataAccess.Concrete;

CourseManager courseManager = new(new CourseDal());

courseManager.GetAll();
