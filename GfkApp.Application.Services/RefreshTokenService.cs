using GfkApp.Application.Interfaces;
using GfkApp.Infrastructure.Interfaces;
using GfkApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Application.Services
{
    public class RefreshTokenService : IRefreshTokenService
    {
        private IUnitOfWork _IUnitOfWork;

        private IRefreshTokenRepository _IRefreshTokenRepository;

        public RefreshTokenService(IUnitOfWork unitOfWork, IRefreshTokenRepository repository)
        {
            this._IUnitOfWork = unitOfWork;
            this._IRefreshTokenRepository = repository;
        }

        public async Task<Domain.Entity.RefreshToken> Get(string id)
        {
            var result = await _IRefreshTokenRepository.FindByIdAsync(id);
            return result;
        }

        public async Task<bool> Save(Domain.Entity.RefreshToken entity)
        {

            _IUnitOfWork.RegisterNew(entity);
            return await _IUnitOfWork.CommitAsync();
        }

        public async Task<bool> Remove(string id)
        {
            var entity = await _IRefreshTokenRepository.FindByIdAsync(id);
            _IUnitOfWork.RegisterDeleted(entity);
            return await _IUnitOfWork.CommitAsync();
        }
    }
}
