
portals = {
	270020400 : 270020000,
	270020500 : 270030000,
	270030100 : 270030110,
	270030200 : 270030210,
	270030300 : 270030310,
	270030400 : 270030410,
	270030500 : 270040000,
	270040000 : 270040100,
	270040100 : 270050000,
}

if ctx.PlayerMapId == 270020500: 
	portal = 4
else: 
	portal = 3

ctx.Warp(portals[ctx.PlayerMapId], portal)