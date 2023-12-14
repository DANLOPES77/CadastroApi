function createPessoa(){
    const primeiroNome = document.getElementById('firstName').value;
    const segundoNome = document.getElementById('middleName').value;
    const ultimoNome = document.getElementById('lastNome').value;
    const cpf = document.getElementById('cpf').value;

    const data ={
        primeiroNome: primeiroNome,
        nomeMeio : segundoNome,
        ultimoNome: ultimoNome,
        cpf: cpf
        
    }

}
fetch('http://localhost:7016/api/Pessoa/Create', {
    method: 'POST',
    headers: {
        'Contente-Type': 'application/json'
    },
    body: JSON.stringify(data)
}),then(response => {
    if(!response.ok){
        alert("Erro ao Criar pessoa");
    }
    alert("pessoa criada com sucesso!");
    window.location.href = 'index.html';
})