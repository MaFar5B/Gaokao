import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt
import warnings

warnings.filterwarnings('ignore')
plt.rcParams["font.sans-serif"]=["SimHei"]
plt.rcParams["axes.unicode_minus"]=False

###读入分数获取学校（一刀切简单衔接版）

def get_rank(grade_in, data):
    all_rank = data
    rank_out = all_rank[all_rank['grade'] == int(grade_in)]
    return rank_out['rank'].astype(str).iloc[0]
