using Api.Livraria.Data;
using Api.Livraria.Dto.Autor;
using Api.Livraria.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Livraria.Services.Autor
{
    public class AutorService : IAutorInterface
    {

        private readonly AppDbContext _context;

        public AutorService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<List<AutorModel>>> ListarAutores()
        {
            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>();
            try
            {

                var autores = await _context.Autores.ToListAsync();

                resposta.Dados = autores;
                resposta.Mensagem = "Todos os autores foram coletados!";

                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }

        public Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<AutorModel>>> CriarAutor(AutorCriacaoDto autorCriacaoDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<AutorModel>>> EditarAutor(AutorEdicaoDto autorEdicaoDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<AutorModel>>> ExcluirAutor(int idAutor)
        {
            throw new NotImplementedException();
        }

        
    }
}
