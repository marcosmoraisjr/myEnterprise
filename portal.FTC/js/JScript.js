function click() 
{
	if (event.button==2||event.button==3) 
	{
		//alert('MMSTEC ©\n\Todos os Direitos Reservados.')
	}
} 
document.onmousedown=click


var selected;
function selectRowEffect(object) 
{
	if (!selected) 
	{
		if (document.getElementById) 
		{
			selected = document.getElementById('defaultSelected');
		} else 
		{
			selected = document.all['defaultSelected'];
		}
	}
	if (selected) selected.className = 'moduleRow';
	object.className = 'moduleRowSelected';
	selected = object;
}
function rowOverEffect(object) 
{
	if (object.className == 'moduleRow') object.className = 'moduleRowOver';
}
function rowOutEffect(object) 
{
	if (object.className == 'moduleRowOver') object.className = 'moduleRow';
}