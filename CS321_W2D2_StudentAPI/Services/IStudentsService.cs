using System;
using System.Collections.Generic;
using CS321_W2D2_StudentAPI.Models;

namespace CS321_W2D2_StudentAPI.Services
{
    public interface IStudentsService
    {
        Student Add(Student student);       //CREATE
        Student Get(int id);                //READ
        Student Update(Student student);    //UPDATE
        void Remove(Student student);       //DELETE
        IEnumerable<Student> GetAll();      //LIST
    }
}
