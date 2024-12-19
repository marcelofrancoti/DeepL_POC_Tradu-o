# POC DeepL API NET CORE C#

Esta é uma Prova de Conceito (POC) que utiliza a API do DeepL para tradução de textos. Para que a POC funcione corretamente, é necessário obter uma chave de autenticação da API, que exige um plano pago, conforme descrito abaixo.

## Explicação

### Chave de Autenticação

A chave de API é fornecida ao assinar um dos planos pagos do DeepL (Starter, Advanced, Ultimate ou Enterprise). Sem essa chave válida, você não conseguirá acessar a API.

### Custos Mensais

- **Starter**: US$ 10,49/mês por usuário. Traduz até 1 milhão de caracteres/mês.
- **Advanced**: US$ 34,49/mês por usuário. Tradução ilimitada de textos e arquivos.
- **Ultimate**: US$ 68,99/mês por usuário. Recursos mais avançados e maior capacidade de upload.
- **Enterprise**: Preço sob consulta para grandes volumes e empresas.

### Plano Gratuito

O plano gratuito tem algumas limitações:
- Tradução de textos limitada.
- Tradução de até 3 arquivos não editáveis por mês.
- Upload máximo de arquivos de até 5 MB.

### Importância da Chave de API

A chave de API é necessária para autenticar e autorizar as chamadas feitas à API do DeepL. Sem um plano pago ou uma chave válida, suas chamadas retornarão erros de autorização (403 Forbidden).

## Próximos Passos

1. Escolha um plano no site oficial do DeepL (https://www.deepl.com).
2. Obtenha a chave de API após assinar o plano.
3. Substitua a chave no código da POC para testar as funcionalidades de tradução.

## Imagem

![Imagem explicativa sobre os planos DeepL](path-to-your-image.png)
