using AutoMapper;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.App_Start;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/customers
        public IHttpActionResult GetCustomers()
        {
            var customers = _context.Customers.Include(c => c.MembershipType)
                .ToList().Select(MappingConfig.Mapper.Map<Customer, CustomerDto>);

            return Ok(customers);
        }

        // GET /api/customers/1
        public IHttpActionResult GetCustomers(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.ID == id);

            if (customer == null)
                NotFound();

            return Ok(MappingConfig.Mapper.Map<Customer, CustomerDto>(customer));
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = MappingConfig.Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.ID = customer.ID; // customer.ID has been set by the database at this point

            return Created(new Uri(Request.RequestUri + "/" + customer.ID), customerDto);
        }

        // PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.Customers.SingleOrDefault(c => c.ID == id);

            if (customerInDb == null)
                return NotFound();

            MappingConfig.Mapper.Map(customerDto, customerInDb);
            _context.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.ID == id);

            if (customerInDb == null)
                return NotFound();

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
