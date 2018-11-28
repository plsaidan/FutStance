using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutStance.Data
{
    public enum ReleaseType
    {
        [Display(Name ="Album/LP")]
        Album = 1,
        [Display(Name ="Mixtape/EP")]
        Mixtape,
        Single
    }
    public enum MusicGenreType
    {
        Alternative = 1,
        [Display(Name ="African Music")]
        AfricanMusic,
        Americana,
        Blues,
        Funk,
        [Display(Name ="Christian & Gospel")]
        Gospel,
        [Display(Name ="Classic Rock")]
        ClassicRock,
        [Display(Name ="Children's")]
        Child,
        Classical,
        Country,
        Dance,
        Electronic,
        Experimental,
        [Display(Name ="Hard Rock")]
        HardRock,
        [Display(Name ="Hip-Hop/Rap")]
        Rap,
        Holiday,
        Indie,
        Jazz,
        [Display(Name ="K-Pop")]
        KPop,
        Latino,
        Metal,
        Oldies,
        Pop,
        [Display(Name ="R&B")]
        RandB,
        Reggae,
        Rock,
        Soul,
        [Display(Name ="Stage & Screen")]
        StageScreen,
        Other

    }
    public class MusicReview
    {
        [Key]
        public int MusicReviewId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Artist { get; set; }

        [Required]
        public string MusicTitle { get; set; }

        [Required]
        public ReleaseType ReleaseType { get; set; }

        [Required]
        public MusicGenreType MusicGenreType { get; set; }

        [Required]
        public string UserReview { get; set; }

        [Required]
        public bool StarRating { get; set; }


    }
}
