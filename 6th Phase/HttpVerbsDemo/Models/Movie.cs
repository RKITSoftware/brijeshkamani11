using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HttpVerbsDemo.Models
{
    public class Movie
    {
        /// <summary>
        /// Movie ID For Extracting Unique Rows
        /// </summary>
        [Key]
        [DisplayName("Movie ID")]

        public int MovieId { get; set; }

        /// <summary>
        /// Title of Movie
        /// </summary>
        [DisplayName("Movie Name")]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "Only Max 100 Characters Allowed in Movie Name Field")]
        [Required(ErrorMessage = "Movie Name Field is Required")]
        public string MovieName { get; set; }

        /// <summary>
        /// Release Year of Movie
        /// </summary>
        [DisplayName("Release Year")]
        public int ReleaseYear { get; set; }

        /// <summary>
        /// Name of Director of Movie
        /// </summary>
        [DisplayName("Director Name")]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "Only Max 100 Characters Allowed in Director Name Field")]
        public string DirectorName { get; set; }

        /// <summary>
        /// Language Of Movie
        /// </summary>
        [DisplayName("Movie Language")]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "Only Max 100 Characters Allowed in Movie Language Field")]
        public string MovieLang { get; set; }

        /// <summary>
        /// Origin Country Name of Movie
        /// </summary>
        [DisplayName("Movie Country")]
        [DataType(DataType.Text)]
        [StringLength(45, ErrorMessage = "Only Max 45 Characters Allowed in Movie Country Field")]
        public string MovieCountry { get; set; }

    }
}