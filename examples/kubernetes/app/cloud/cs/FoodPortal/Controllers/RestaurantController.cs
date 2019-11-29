﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodPortal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
        private static readonly Restaurant[] restaurants = new Restaurant[]
        {
            new Restaurant {
                Id = "ltv",
                Name = "La Tavola"
            },
            new Restaurant {
                Id = "pbz",
                Name = "Pizza Boyz"
            },
            new Restaurant {
                Id = "spz",
                Name = "Side Pizzeria"
            }
        };

        private readonly ILogger<RestaurantController> _logger;

        public RestaurantController(ILogger<RestaurantController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Restaurant> Get()
        {
            var rng = new Random();
            return restaurants;
        }
    }
}
