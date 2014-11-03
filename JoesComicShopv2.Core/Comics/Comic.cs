using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesComicShopv2.Comics
{
    [Table("Comics")]
    public class Comic : Entity
    {
        public virtual string Title { get; set; }
        public virtual string Series { get; set; }
        public virtual string Number { get; set; }
        public virtual string Writer { get; set; }
        public virtual string Penciller { get; set; }
        public virtual string MainCharacterOrTeam { get; set; }
        public virtual string Characters { get; set; }
        public virtual string Locations { get; set; }
        public virtual string Teams { get; set; }
        public virtual string Format { get; set; }
        public virtual string CoverArtist { get; set; }
        public virtual ushort Volume { get; set; }
        public virtual bool VolumeSpecified { get; set; }
        public virtual string Notes { get; set; }
        public virtual string Web { get; set; }
        public virtual string Added { get; set; }
        public virtual bool Missing { get; set; }
        public virtual bool MissingSpecified { get; set; }
        public virtual string Opened { get; set; }
        public virtual bool OpenedSpecified { get; set; }
        public virtual string LastOpenedFromListId { get; set; }
        public virtual string CustomValuesStore { get; set; }
        public virtual string ComicId { get; set; }
        public virtual string File { get; set; }
        public virtual bool IsDynamicSource { get; set; }
        public virtual bool IsDynamicSourceSpecified { get; set; }
    }
}
