﻿// <copyright file="LaptopLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyLaptopShop.Logic.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using MyLaptopShop.Data.Models;
    using MyLaptopShop.Logic.Interfaces;
    using MyLaptopShop.Repository.Classes;
    using MyLaptopShop.Repository.Interfaces;

    /// <summary>
    /// Logic class.
    /// </summary>
    public class LaptopLogic : ILaptopLogic<Pricing>
    {
        private IBrandRepository brandrepo;
        private ILaptopRepository laptoprepo;
        private ISpecificationRepository specrepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="LaptopLogic"/> class.
        /// </summary>
        /// <param name="brandrepo">Brand repository instance.</param>
        /// <param name="laptoprepo">Laptop repository instance.</param>
        /// <param name="specrepo">Specification repository instance.</param>
        public LaptopLogic(IBrandRepository brandrepo, ILaptopRepository laptoprepo, ISpecificationRepository specrepo)
        {
            this.brandrepo = brandrepo;
            this.laptoprepo = laptoprepo;
            this.specrepo = specrepo;
        }

        /// <summary>
        /// Add a new brand to the DB.
        /// </summary>
        /// <param name="id">New ID.</param>
        /// <param name="name">Name of the brand.</param>
        /// <param name="foundationyear">Year of foundation.</param>
        /// <param name="headquarters">Headquarters place.</param>
        /// <param name="ceoname">Name of the companys CEO.</param>
        public void AddBrand(int id, string name, int foundationyear, string headquarters, string ceoname)
        {
            Brand tmp = new Brand(id, name, foundationyear, headquarters, ceoname);
            this.brandrepo.Add(tmp);
        }

        /// <summary>
        /// Add a new laptop to the DB.
        /// </summary>
        /// <param name="id">Id of the laptop.</param>
        /// <param name="brandid">ID of the laptops brand.</param>
        /// <param name="name">Name of the laptop.</param>
        /// <param name="releaseyear">The year when the laptop was released.</param>
        /// <param name="baseprice">Base price.</param>
        public void AddLaptop(int id, int brandid, string name, int releaseyear, int baseprice)
        {
            Laptop tmp = new Laptop(id, brandid, name, releaseyear, baseprice);
            this.laptoprepo.Add(tmp);
        }

        /// <summary>
        /// Add a new specification to the DB.
        /// </summary>
        /// <param name="id">Id of the specification.</param>
        /// <param name="laptopid">The id of the laptop witch has the specification.</param>
        /// <param name="name">Name of the specification.</param>
        /// <param name="cpu">Name of the cpu.</param>
        /// <param name="graphicscard">Nem of the Graphicscard.</param>
        /// <param name="ram">Gb of RAM.</param>
        /// <param name="price">Additional price of the specification.</param>
        public void AddSpec(int id, int laptopid, string name, string cpu, string graphicscard, int ram, int price)
        {
            Specification tmp = new Specification(id, laptopid, name, cpu, graphicscard, ram, price);
            this.specrepo.Add(tmp);
        }

        /// <summary>
        /// Deleting the brand with the given ID.
        /// </summary>
        /// <param name="id">ID of the brand we want to delete.</param>
        public void DeleteBrand(int id)
        {
            this.brandrepo.Delete(id);
        }

        /// <summary>
        /// Deleting the laptop with the given ID.
        /// </summary>
        /// <param name="id">ID of the laptop we want to delete.</param>
        public void DeleteLaptop(int id)
        {
            this.laptoprepo.Delete(id);
        }

        /// <summary>
        /// Deleting the laptop with the given ID.
        /// </summary>
        /// <param name="id">ID of the laptop we want to delete.</param>
        public void DeleteSpec(int id)
        {
            this.specrepo.Delete(id);
        }

        /// <summary>
        /// Gives back the istance witch belongs to the parameter ID.
        /// </summary>
        /// <param name="id">ID of the parameter we want to get.</param>
        /// <returns>The instance with the parameter ID.</returns>
        public Brand BrandGetOne(int id)
        {
            return this.brandrepo.GetOne(id);
        }

        /// <summary>
        /// Gives back the istance witch belongs to the parameter ID.
        /// </summary>
        /// <param name="id">ID of the parameter we want to get.</param>
        /// <returns>The instance with the parameter ID.</returns>
        public Laptop LaptopGetOne(int id)
        {
            return this.laptoprepo.GetOne(id);
        }

        /// <summary>
        /// Gives back the istance witch belongs to the parameter ID.
        /// </summary>
        /// <param name="id">ID of the parameter we want to get.</param>
        /// <returns>The instance with the parameter ID.</returns>
        public Specification SpecGetOne(int id)
        {
            return this.specrepo.GetOne(id);
        }

        /// <summary>
        /// Updating a brands parameters.
        /// </summary>
        /// <param name="id">Id of the brand.</param>
        /// <param name="name">New name of the brand.</param>
        /// <param name="foundationyear">New year of foundation of the brand.</param>
        /// <param name="headquarters">New headquarters of the brand.</param>
        /// <param name="ceoname">New name of the brands CEO.</param>
        public void BrandUpdate(int id, string name, int foundationyear, string headquarters, string ceoname)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updating a laptops parameters.
        /// </summary>
        /// <param name="id">Id of the laptop.</param>
        /// <param name="brandid">The ID of the laptops brand.</param>
        /// <param name="name">The new name of the laptop.</param>
        /// <param name="releaseyear">The new year of the laptops release.</param>
        /// <param name="baseprice">The new price of the laptop.</param>
        public void LaptopUpdate(int id, int brandid, string name, int releaseyear, int baseprice)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updating a specification parameters.
        /// </summary>
        /// <param name="id">Id of the specification.</param>
        /// <param name="laptopid">Id of the specifications laptop.</param>
        /// <param name="name">New name of the specification.</param>
        /// <param name="cpu">New CPUs name.</param>
        /// <param name="graphicscard">New nameof the graphicscard.</param>
        /// <param name="ram">New Gb of RAMs.</param>
        /// <param name="price">Additional price of the specification.</param>
        public void SpecUpdate(int id, int laptopid, string name, string cpu, string graphicscard, int ram, int price)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gives back all the brands.
        /// </summary>
        /// <returns>List of all brands.</returns>
        public IList<Brand> GetAllBrand()
        {
            return this.brandrepo.GetAll().ToList();
        }

        /// <summary>
        /// Gives back all the laptops.
        /// </summary>
        /// <returns>List of all laptops.</returns>
        public IList<Laptop> GetAllLaptop()
        {
            return this.laptoprepo.GetAll().ToList();
        }

        /// <summary>
        /// Gives back all the specifications.
        /// </summary>
        /// <returns>List of all specifications.</returns>
        public IList<Specification> GetAllSpec()
        {
            return this.specrepo.GetAll().ToList();
        }

        /// <summary>
        /// Lists the name, brand name and the total price of the laptop with a chosen specification.
        /// </summary>
        /// <returns>List of Pricing type.</returns>
        public IList<Pricing> Pricing()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// List the number of laptops group by brands.
        /// </summary>
        /// <returns>List of strings.</returns>
        public IList<string> LaptopCount()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists laptops with average specification prices.
        /// </summary>
        /// <returns>List of fromed strings of the results.</returns>
        public IList<string> AvgSpecPrice()
        {
            throw new NotImplementedException();
        }
    }
}