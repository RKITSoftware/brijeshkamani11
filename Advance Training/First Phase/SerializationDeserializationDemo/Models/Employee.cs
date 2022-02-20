using System;
using System.ComponentModel.DataAnnotations;


namespace SerializationDeserializationDemo.Models
{
    /// <summary>
    /// Employee Model That Contains All Employee Details.
    /// </summary>
    [Serializable]
    public class Employee
    {
        #region Public Properties
        /// <summary>
        /// Contains ID of Employee.
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Contains Name Of Employee
        /// </summary>
        [Required(ErrorMessage = "Employe.Name Should not be Empty")]
        [StringLength(50, ErrorMessage = "Name Should not be Greater than 50 Length")]
        public string Name { get; set; }

        /// <summary>
        /// Contains Salary Of Employee
        /// </summary>
        public float Salary
        { get; set; }



        /// <summary>
        /// Get Value of Employee Age --read only.
        /// </summary>
        public int Age
        {
            get { return _age; }
        }

        /// <summary>
        /// Contains Birthday Of Employee
        /// </summary>
        public DateTime Birthdate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
                // Calculating Age Of Employee based on Birthday.
                _age = (int)((DateTime.Now - _birthDate).TotalDays / 365);
            }
        }
        /// <summary>
        /// Contains Value of Joining Date
        /// </summary>
        public DateTime JoiningDate { get; set; }
        #endregion

        #region Private Fields
        private DateTime _birthDate;
        private int _age;
        #endregion

    }
}
