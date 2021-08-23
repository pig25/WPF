3D 軟體:https://www.blender.org/  
WPF Helix Toolkit 插件:https://github.com/helix-toolkit/helix-toolkit  
WPF Material Design In XAML Toolkit 插件:https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit  

SELECT *
FROM (
	SELECT l.畫面, l.功能,l.存在
	FROM dbo.腳色樣板 l
) t 
PIVOT (
	-- 設定彙總欄位及方式
	Count(存在) 
	-- 設定轉置欄位，並指定轉置欄位中需彙總的條件值作為新欄位
	FOR 功能 IN ([新增], [刪除], [變更],[唯獨])
) p;
