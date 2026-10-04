using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace Unit4_MVC_JosephVo.Models
{

    public class StudentModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Credits { get; set; }

        public StudentModel()
        {
            Id = -1;
            Name = "Non";
            Credits = -1;
        }
        public StudentModel(int id, string name, int credits)
        {
            Id = id;
            Name = name;
            Credits = credits;
        }
    }
}