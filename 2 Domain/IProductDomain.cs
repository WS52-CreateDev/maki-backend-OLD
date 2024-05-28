﻿using _3_Data.Models;

namespace _2_Domain;

public interface IProductDomain
{
    Task<bool> SaveAsync(Product data);

    Task<bool> UpdateAsync(Product data, int id);

    Task<bool> DeleteAsync(int id);
    
}