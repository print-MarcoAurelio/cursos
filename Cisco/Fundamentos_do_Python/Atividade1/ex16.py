# Exercício 16 Faça um algoritmo que pergunte se o usuário é motorista, caso sim, faça
# outras duas perguntas: Se ele está de cinto de segurança, se bebeu bebidas
# alcoólicas. O programa deve imprimir se ele está pronto para dirigir caso contrário
# imprimir as penalidades para falta de uso de cinto de segurança ou ter consumido
# bebidas alcoólicas.

e_motorista = input("Você é motorista? (sim/não): ")
if e_motorista == "sim":
    cinto_segurnaca = input("Você está usando cinto de segurança? (sim/não): ")
    bebeu_alcool = input("Você consumiu bebidas alcólicas? (sim/não): ")
    if cinto_segurnaca == "sim" and bebeu_alcool == "não":
        print("Você está pronto para dirigir!")
    else:
        if cinto_segurnaca == "não":
            print("Você não está usando cinto de segurança. Penalidade aplicável!")
        if bebeu_alcool == "sim":
            print("Você consumiu bebidas alcoólicas. Penalidade aplicável!")
else:
    print("Você não e motorista.")
