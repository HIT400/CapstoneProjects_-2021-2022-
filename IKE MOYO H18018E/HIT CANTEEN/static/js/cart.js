var updateBtns = document.getElementsByClassName('update-cart')

for (i = 0; i < updateBtns.length; i++) {
	updateBtns[i].addEventListener('click', function(){
		var product_id = this.dataset.product
		var action = this.dataset.action
		console.log('product_id:', product_id, 'Action:', action)
		console.log('USER:', user)

		updateUserOrder(product_id, action)

	})
}

function updateUserOrder(product_id, action){
	console.log('User is authenticated, sending data...')

		var url = '/update_item/'

		fetch(url, {
			method:'POST',
			headers:{
				'Content-Type':'application/json',
				'X-CSRFToken':csrftoken,
			}, 
			body:JSON.stringify({'product_id':product_id, 'action':action})
		})
		.then((response) => {
		   return response.json();
		})
		.then((data) => {
		    location.reload()
		});
}

function addCookieItem(product_id, action){
	console.log('User is not authenticated')

	if (action == 'add'){
		if (cart[product_id] == undefined){
		cart[product_id] = {'quantity':1}

		}else{
			cart[product_id]['quantity'] += 1
		}
	}

	if (action == 'remove'){
		cart[product_id]['quantity'] -= 1

		if (cart[product_id]['quantity'] <= 0){
			console.log('Item should be deleted')
			delete cart[product_id];
		}
	}
	console.log('CART:', cart)
	document.cookie ='cart=' + JSON.stringify(cart) + ";domain=;path=/"

	location.reload()
}
