using Newtonsoft.Json;
using projetoPokemon.Aplication.Interfaces;
using projetoPokemon.Domain.Entities;
using projetoPokemon.Helper.Interfaces;

namespace projetoPokemon.Aplication.Services
{
    /// <summary>
    /// Serviço para obter informações sobre Pokémon, espécies, tipos e habilidades.
    /// </summary>
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;
        private readonly IPokemonApiRoutes _apiRoutes;

        /// <summary>
        /// Inicializa uma nova instância do <see cref="PokemonService"/>.
        /// </summary>
        /// <param name="httpClient">Cliente HTTP para fazer solicitações.</param>
        /// <param name="apiRoutes">Interface para obter URLs da API.</param>
        public PokemonService(HttpClient httpClient, IPokemonApiRoutes apiRoutes)
        {
            _httpClient = httpClient;
            _apiRoutes = apiRoutes;
        }

        /// <summary>
        /// Obtém as informações detalhadas de um Pokémon pelo nome.
        /// </summary>
        /// <param name="name">Nome do Pokémon.</param>
        /// <returns>Retorna os dados do Pokémon.</returns>
        /// <exception cref="Exception">Lança uma exceção se houver erro na obtenção dos dados.</exception>
        public async Task<Pokemon> GetPokemonAsync(string name)
        {
            try
            {
                var response = await _httpClient.GetAsync(_apiRoutes.GetPokemonEndpoint(name));
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Pokemon>(content);
                }

                throw new Exception("Erro ao obter informações do Pokémon. Verifique o nome e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar Pokémon: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtém informações da espécie de um Pokémon pelo nome.
        /// </summary>
        /// <param name="name">Nome do Pokémon.</param>
        /// <returns>Retorna os dados da espécie do Pokémon.</returns>
        /// <exception cref="Exception">Lança uma exceção se houver erro na obtenção dos dados.</exception>
        public async Task<PokemonSpecies> GetPokemonSpeciesAsync(string name)
        {
            try
            {
                var response = await _httpClient.GetAsync(_apiRoutes.GetPokemonSpeciesEndpoint(name));
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<PokemonSpecies>(content);
                }

                throw new Exception("Erro ao obter informações da espécie do Pokémon.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar espécie do Pokémon: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtém as informações de um tipo de Pokémon pelo ID.
        /// </summary>
        /// <param name="id">ID do tipo do Pokémon.</param>
        /// <returns>Retorna os dados do tipo de Pokémon.</returns>
        /// <exception cref="Exception">Lança uma exceção se houver erro na obtenção dos dados.</exception>
        public async Task<Domain.Entities.Type> GetTypeAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync(_apiRoutes.GetTypeEndpoint(id));
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Domain.Entities.Type>(content);
                }

                throw new Exception("Erro ao obter informações do tipo.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar tipo: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtém as informações de uma habilidade de Pokémon pelo nome.
        /// </summary>
        /// <param name="name">Nome da habilidade do Pokémon.</param>
        /// <returns>Retorna os dados da habilidade do Pokémon.</returns>
        /// <exception cref="Exception">Lança uma exceção se houver erro na obtenção dos dados.</exception>
        public async Task<Ability> GetAbilityAsync(string name)
        {
            try
            {
                var response = await _httpClient.GetAsync(_apiRoutes.GetAbilityEndpoint(name));
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Ability>(content);
                }

                throw new Exception("Erro ao obter informações da habilidade.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar habilidade: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtém a lista completa de Pokémon.
        /// </summary>
        /// <returns>Retorna uma lista de Pokémon.</returns>
        /// <exception cref="Exception">Lança uma exceção se houver erro na obtenção dos dados.</exception>
        public async Task<PokemonListResponse> GetPokemonListAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(_apiRoutes.GetPokemonListEndpoint());
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<PokemonListResponse>(content);
                }

                throw new Exception("Erro ao obter lista de Pokémon.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar lista de Pokémon: {ex.Message}");
            }
        }
    }
}
