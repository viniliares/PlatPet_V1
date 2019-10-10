using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PlatPet.Models;
using System.Windows.Input;
using PlatPet.Services.UsuarioPessoas;

namespace PlatPet.ViewModel.CadastroUsuario
{
    public class CadastroUsuarioViewModel : BaseViewModel
    {
        private IUsuarioPessoaService uService = new UsuarioPessoaService();

        private UsuarioPessoa UsuarioPessoa;
        public ICommand GravarCommand { get; set; }
        public ICommand NovoCommand { get; set; }


        public CadastroUsuarioViewModel()
        {
            RegistrarCommands();
            UsuarioPessoa = new UsuarioPessoa();
        }

        private void RegistrarCommands()
        {
            GravarCommand = new Command(async () =>
            {
                await GravarAsync();
                MessagingCenter.Send<string>("Dado salvo com sucesso.", "InformacaoCRUD");
            });
        }

        private async Task GravarAsync()
        {
            var ehNovoUsuario = (UsuarioPessoa.IdPessoa == 0 ? true : false);
            UsuarioPessoa.StatusUsuario = "2";
            UsuarioPessoa.TipoUsuario = 1;
        }

        /*private void AtualizarPropriedadesParaVisao(bool ehNovoObjeto)
        {
            if (ehNovoObjeto)
            {

                this.UsuarioPessoa = new UsuarioPessoa();
            }
        }*/

        
        public string Usuario
        {
            get { return this.UsuarioPessoa.UserUsuario; }
            set
            {
                this.UsuarioPessoa.UserUsuario = value;
                OnPropertyChanged();
            }
        }

        public string Nome
        {
            get { return this.UsuarioPessoa.NomePessoa; }
            set
            {
                //Atribuirá valor a propriedade
                this.UsuarioPessoa.NomePessoa = value;

                //Atuálizará a propriedade ligada a view
                //Método presente na classe herdada
                OnPropertyChanged();
            }
        }

        public string Sobrenome
        {
            get { return this.UsuarioPessoa.SobrenomePessoa; }
            set
            {
                this.UsuarioPessoa.SobrenomePessoa = value;
                OnPropertyChanged();
            }
        }

        public string Senha
        {
            get { return this.UsuarioPessoa.PassUsuario; }
            set
            {
                this.UsuarioPessoa.PassUsuario = value;
                OnPropertyChanged();
            }
        }

        public string CPF
        {
            get { return this.UsuarioPessoa.CPFPessoa; }
            set
            {
                this.UsuarioPessoa.CPFPessoa = value;
                OnPropertyChanged();
            }
        }

        public string Telefone
        {
            get { return this.UsuarioPessoa.TelefonePessoa; }
            set
            {
                this.UsuarioPessoa.TelefonePessoa = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return this.UsuarioPessoa.EmailPessoa; }
            set
            {
                this.UsuarioPessoa.EmailPessoa = value;
                OnPropertyChanged();
            }
        }

        public string Endereco
        {
            get { return this.UsuarioPessoa.EnderecoPessoa; }
            set
            {
                this.UsuarioPessoa.EnderecoPessoa = value;
                OnPropertyChanged();
            }
        }
    }
}
