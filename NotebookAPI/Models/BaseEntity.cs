using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Web;

namespace NotebookAPI.Models
{
    //[Serializable]
    //[KnownType(typeof(Contact))]
    //[KnownType(typeof(ContactType))]
    //[DataContract(IsReference = true)]
    public class BaseEntity
    {
        [JsonIgnore]
        public int Id { get; set; }
    }
}