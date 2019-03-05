﻿using System;

namespace NiuNiu.BlogEntry.Entity
{
    using System.ComponentModel.DataAnnotations;

    ///<summary>
    /// 用户表
    ///</summary>
    public partial class Users
    {
        public Users()
        {
            CreateDate = DateTime.Now;
            Name = "";
            Sex = 0;
            Birthday = DateTime.Now;
            Phone = "";
            Email = "";
            QQ = "";
            Address = "";
            ImgPath = "";
            State = 1;
            Admin_UserId = 0;
        }

        /// <summary>
        /// Desc:主键Id
        /// Default:
        /// Nullable:False
        /// </summary>        
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Desc:用户名
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string UserName { get; set; }

        /// <summary>
        /// Desc:密码
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Password { get; set; }

        /// <summary>
        /// Desc:姓名
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Name { get; set; }

        /// <summary>
        /// Desc:性别
        /// Default:
        /// Nullable:False
        /// </summary>           
        public int Sex { get; set; }

        /// <summary>
        /// Desc:生日
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Desc:手机
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Phone { get; set; }

        /// <summary>
        /// Desc:邮箱
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Email { get; set; }

        /// <summary>
        /// Desc:QQ
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string QQ { get; set; }

        /// <summary>
        /// Desc:地址
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Address { get; set; }

        /// <summary>
        /// Desc:头像
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ImgPath { get; set; }

        /// <summary>
        /// Desc:我的简介
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string MyDesc { get; set; }

        /// <summary>
        /// Desc:创建时间
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Desc:是否启用
        /// Default:
        /// Nullable:True
        /// </summary>  
        public int State { get; set; }

        /// <summary>
        /// Desc:是否启用
        /// Default:
        /// Nullable:True
        /// </summary>  
        public int Admin_UserId { get; set; } 
    }
}
