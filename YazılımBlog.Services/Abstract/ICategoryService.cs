﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımBlog.Entities.Concreate;
using YazılımBlog.Entities.Dtos;
using YazılımBlog.Shared.Utilities.Results.Abstract;

namespace YazılımBlog.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> Get(int categoryId);
        Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDto(int categoryId);
        Task<IDataResult<CategoryListDto>> GetAll();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeleted();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive();
        Task<IDataResult<CategoryDto>> Add(CategoryAddDto categoryAddDto, string createdByName);
        Task<IDataResult<CategoryDto>> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        Task<IDataResult<CategoryDto>> Delete(int categoryId, string modifiedByName);
        Task<IResult> HardDelete(int categoryId);
        Task<IDataResult<int>> Count();
        Task<IDataResult<int>> CountByIsDeleted();
    }
}
