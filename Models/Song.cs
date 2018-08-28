namespace MyPlaylist.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Song
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Song()
        {
            Playlists = new HashSet<Playlist>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SongId { get; set; }

        [StringLength(120)]
        public string Name { get; set; }

        public int? AlbumId { get; set; }

        [JsonIgnore]
        public virtual Album Album { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Playlist> Playlists { get; set; }
    }
}
