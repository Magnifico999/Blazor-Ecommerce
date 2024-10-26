﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypeService _productTypeService;

        public ProductTypesController(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ProductType>>>> GetProductTypes()
        {
            var result = await _productTypeService.GetProductTypes();

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<ProductType>>>> AddProductType(ProductType productType)
        {
            var result = await _productTypeService.AddProductType(productType);

            return Ok(result);
        }
        
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<ProductType>>>> UpdateProductType(ProductType productType)
        {
            var result = await _productTypeService.UpdateProductType(productType);

            return Ok(result);
        }
        
    }
}
