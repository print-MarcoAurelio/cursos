# Exercício 15 Para votar você deve ter entre 18 anos e menos de 65 anos de idade, faça um programa que pergunte a idade e responda: "É obrigatório votar", casocontrário responda: 
# "Não é obrigatório votar".

idade = int(input("Digite a sua idade: "))
if 18 <= idade < 65:
    print("É obrigatório votar.")
else:
    print("Não é obrigatório votar.")