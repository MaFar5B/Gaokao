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
    request = input()
    #根据分数获取排名
    if(request == "get_rank"):
        score = input()
        rank = process.get_rank(score, data1)
        print(rank)
    if(request == "generate"):
        rank = int(input())
        wish = input()
        cinn = wish.split()
        headers = {'院校名称': [], '专业': [], '2020投档计划数':[],'2020最低分': [], '2020投档最低位次': [],'2021投档计划数':[],'2021最低分':[],'2021投档最低位次':[],'2022投档计划数':[],'2022最低分':[],'2022投档最低位次':[],'特点':[],'X':[],'院校性质':[],'平均最低投档线':[]}
        kong = pd.DataFrame(headers)
        kong.to_csv(f"{Gaokao_path}\Data/result.csv",index=False)

        for major in cinn:
            fl = pd.read_csv(f"{Gaokao_path}\Data\sorts/{major}.csv")
            index1 = np.searchsorted(fl['平均最低投档线'],rank - 3000,side='left')
            index2 = np.searchsorted(fl['平均最低投档线'],rank + 3000,side='left')
            nearest_rows = fl.iloc[index1:index2]
            print(nearest_rows)
            nearest_rows.to_csv(f"{Gaokao_path}\Data/result.csv",mode='a',header=None,index=False)





