'''
Created on 2023年7月20日

@author: MaFar
'''
import process
import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt
import warnings
import os
import numpy as np

file_path = os.path.realpath(__file__)
py_path = os.path.dirname(os.path.abspath(file_path))
Gaokao_path = os.path.dirname(os.path.dirname(py_path))
warnings.filterwarnings('ignore')
plt.rcParams["font.sans-serif"]=["SimHei"]
plt.rcParams["axes.unicode_minus"]=False
data1 = pd.read_csv(f"{Gaokao_path}\Data/grade_line.csv")

if __name__ == '__main__':
    #输入要求
    request = input();
    #根据分数获取排名
    if(request == "get_rank"):
        score = input()
        rank = process.get_rank(score, data1)
        print(rank)
    if(request == "generate"):
        rank = input()
        wish = input()
        cinn = wish.split()
        kong = pd.DataFrame()
        kong.to_csv(f"{Gaokao_path}\Data/result.csv")
        for major in cinn:
            fl = pd.read_csv(f"{Gaokao_path}\Data\sorts/{major}.csv")
            index = np.searchsorted(fl['投档最低位次'],rank,side='left')
            start_index = max(0,index - 7)
            end_index = min(index + 13 , len(fl['投档最低位次']))
            nearest_rows = fl.iloc[start_index:end_index]
            nearest_rows.to_csv(f"{Gaokao_path}\Data/result.csv",mode='a')




