﻿// <copyright file="Brand.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyLaptopShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Dynamic;
    using System.Text;

    /// <summary>
    /// This is the Model class of the Brands.
    /// </summary>
    [Table("Brand")]
    public class Brand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Brand"/> class.
        /// </summary>
        /// <param name="id">The ID of the brand.</param>
        /// <param name="name">The name of the brand.</param>
        /// <param name="foundationYear">The foundation year of the brand.</param>
        /// <param name="headquarters">The headquarters place of the brand.</param>
        /// <param name="ceoname">The name of the CEO of the brand.</param>
        public Brand(int id, string name, int foundationYear, string headquarters, string ceoname)
        {
            this.Id = id;
            this.Name = name;
            this.FoundationYear = foundationYear;
            this.Headquarters = headquarters;
            this.CEOName = ceoname;
        }

        /// <summary>
        /// Gets or sets the id of a brand, this is a key.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the brand.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the foundations yers of the brand.
        /// </summary>
        public int FoundationYear { get; set; }

        /// <summary>
        /// Gets or sets the place of the brands headquarters.
        /// </summary>
        public string Headquarters { get; set; }

        /// <summary>
        /// Gets or Sets the name of the brands CEO.
        /// </summary>
        public string CEOName { get; set; }
    }
}