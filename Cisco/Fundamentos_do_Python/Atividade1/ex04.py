# Exercício 5 Faça um programa que solicite o preço de uma mercadoria e o percentual de desconto. Exiba o valor do desconto e o preço a pagar.

preco_mercadoria = float(input("Digite o preço da mercadoria: "))
percentual_desconto = float(input("Digite o segundo número: "))
valor_desconto = (percentual_desconto / 100) * preco_mercadoria
preco_a_pagar = preco_mercadoria - valor_desconto

print(f"Desconto: R${valor_desconto:.2f}")
print(f"Preço a pagar: R${preco_a_pagar}")
