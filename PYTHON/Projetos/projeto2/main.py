import os
from tkinter.filedialog import askdirectory

caminho = askdirectory(title="Selecione uma pasta")

lista_arquivos = os.listdir(caminho)

locais = {
    "imagens": [".png", ".jpg"],
    "planilhas": [".xlsx", ".xlsm"],
    "pdfs": ["pdf", ".exe", ".doc"],
    "csv": [".csv", ".xls", ".xlsx",],

}

for arquivo in lista_arquivos:
    # 01. Arquivo.pdf
    nome, extansao = os.path.splitext(f"{caminho}/{arquivo}")
    for pasta in locais:
        if extensao in locais[pasta]:
            if not os.path.exists(f"{caminho}/{pasta}"):
                os.mkdir(f"{caminho}/{pasta}")
            os.rename(f"caminho/{arquivo}", f"{caminho}/{pasta}/{arquivo}")