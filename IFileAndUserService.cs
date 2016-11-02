﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PictureGalleryProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFileService" in both code and config file together.
    [ServiceContract]
    public interface IFileAndUserService
    {
        [OperationContract]
        UserInfo[] GetUserInfo();

        [OperationContract]
        FileInfo[] GetFileInfo();
    };

    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
    }

    [DataContract]
    public class FileInfo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FileURL { get; set; }

        [DataMember]
        public int UserID { get; set; }
    }
}