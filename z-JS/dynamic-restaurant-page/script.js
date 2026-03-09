function typesOfFoodFiller(){
    var mainDiv = window.document.getElementById('food-container');
    for(var i = 0; i < 3; i++){

        var foodTypeDiv = window.document.createElement('div');
        foodTypeDiv.classList.add('food-type');

        var imgContainerDiv = window.document.createElement('div');
        imgContainerDiv.classList.add('img-container');

        var imgTag = window.document.createElement('img');
        
        imgTag.src = `./assets/images/food${i+1}.jpg`;

        //<=========
        var imgContentDiv = window.document.createElement('div');
        imgContentDiv.classList.add('img-content');

        var h3Tag = window.document.createElement('h3');
        if(i == 0) h3Tag.innerText = 'Fruite';
        else if(i == 1) h3Tag.innerText = 'Vegetable';
        else if(i == 2) h3Tag.innerText = 'Grin';

        var anchorTag = window.document.createElement('a');
        anchorTag.classList.add('btn');
        anchorTag.classList.add('btn-primary');
        anchorTag.innerText = 'Learn More';

        imgContentDiv.appendChild(h3Tag);
        imgContentDiv.appendChild(anchorTag);
        //=========>

        imgContainerDiv.appendChild(imgTag);
        imgContainerDiv.appendChild(imgContentDiv);

        foodTypeDiv.appendChild(imgContainerDiv);


        mainDiv.appendChild(foodTypeDiv);

    }
}

document.addEventListener('DOMContentLoaded', function() {
    typesOfFoodFiller();
    foodMenuContainerFiller();
    fillCustomers();
 }, false);

foodMenuItems = [
    {
        name:'Salad',
        description:'Lorem ipsum dolor sit amet consectetur adipisicing elit.',
        descriptionTwo:'Non, quae.',
        price:'Price: ₹ 250',
        image:'./assets/images/food-menu1.jpg'
    },
    {
        name:'Fruit & Nuts',
        description:'Lorem ipsum dolor sit amet consectetur adipisicing elit.',
        descriptionTwo:'Non, quae.',
        price:'Price: ₹ 250',
        image:'./assets/images/food-menu2.jpg'
    },
    {
        name:'Vegetables',
        description:'Lorem ipsum dolor sit amet consectetur adipisicing elit.',
        descriptionTwo:'Non, quae.',
        price:'Price: ₹ 250',
        image:'./assets/images/food-menu3.jpg'
    },
    {
        name:'Fried Vegetables',
        description:'Lorem ipsum dolor sit amet consectetur adipisicing elit.',
        descriptionTwo:'Non, quae.',
        price:'Price: ₹ 250',
        image:'./assets/images/food-menu4.jpg'
    },
    {
        name:'Ice Cream',
        description:'Lorem ipsum dolor sit amet consectetur adipisicing elit.',
        descriptionTwo:'Non, quae.',
        price:'Price: ₹ 250',
        image:'./assets/images/food-menu5.jpg'
    },
    {
        name:'Fruits',
        description:'Lorem ipsum dolor sit amet consectetur adipisicing elit.',
        descriptionTwo:'Non, quae.',
        price:'Price: ₹ 250',
        image:'./assets/images/food-menu6.jpg'
    },

]

function foodMenuContainerFiller(){
    var foodMenuContainerDiv = document.getElementsByClassName('food-menu-container');

    foodMenuItems.forEach(item => {
        var foodMenuItemDiv = window.document.createElement('div');
        foodMenuItemDiv.classList.add('food-menu-item');

        var foodImageDiv = window.document.createElement('div');
        foodImageDiv.classList.add('food-img');
        var imgTag = window.document.createElement('img');
        imgTag.src = item.image;
        foodImageDiv.appendChild(imgTag);

        var foodDescriptionDiv = window.document.createElement('div');
        foodDescriptionDiv.classList.add('food-description');

        var h2Tag = window.document.createElement('h2');
        h2Tag.classList.add('food-title');
        h2Tag.innerText = item.name;
        foodDescriptionDiv.appendChild(h2Tag);

        var pTag = window.document.createElement('p');
        pTag.innerText = `${item.description}${item.descriptionTwo}`;
        foodDescriptionDiv.appendChild(pTag);

        var priceTag = window.document.createElement('p');
        priceTag.classList.add('food-price');
        priceTag.innerText = item.price;

        foodDescriptionDiv.appendChild(priceTag);

        foodMenuItemDiv.appendChild(foodImageDiv);
        foodMenuItemDiv.appendChild(foodDescriptionDiv);

        foodMenuContainerDiv[0].appendChild(foodMenuItemDiv);

    });
}


customers = [
    {
        customerName:'Ben Roy',
        customerImage:'./assets/images/male-photo3.jpg',
        rating:5,
        review:'Very Nice Restaurant'
    },
    {
        customerName:'Amelia Watson',
        customerImage:'./assets/images/female-photo1.jpg',
        rating:4,
        review:'Tasty Food'
    },
    {
        customerName:'Ross Lee',
        customerImage:'./assets/images/male-photo1.jpg',
        rating:5,
        review:'Aesthetic environment'
    }
]
function fillCustomers(){
    var mainDiv = window.document.getElementsByClassName('testimonial-container');
    customers.forEach(customer=>{
        var boxDiv = window.document.createElement('div');
        boxDiv.classList.add('testimonial-box');

        var customerDetailBox = window.document.createElement('div');
        customerDetailBox.classList.add('customer-detail');
        var customerPhotoDiv = window.document.createElement('div');
        customerPhotoDiv.classList.add('customer-photo');
        var customerImg = window.document.createElement('img');
        customerImg.src = customer.customerImage;
        var customerName = window.document.createElement('p');
        customerName.classList.add('customer-name');
        customerName.innerText = customer.customerName;
        customerPhotoDiv.appendChild(customerImg);
        customerPhotoDiv.appendChild(customerName);
        customerDetailBox.appendChild(customerPhotoDiv);


        var ratingBox = window.document.createElement('div');
        ratingBox.classList.add('star-rating');
        for(var i = 0; i <customer.rating;i++){
            var span = window.document.createElement('span');
            span.classList.add('fa');
            span.classList.add('fa-star');
            span.classList.add('checked');
            ratingBox.appendChild(span);
        }



        var customerReview = window.document.createElement('p');
        customerReview.classList.add('testimonial-text');
        customerReview.innerText = customer.review;

        boxDiv.appendChild(customerDetailBox);
        boxDiv.appendChild(ratingBox);
        boxDiv.appendChild(customerReview);

        mainDiv[0].appendChild(boxDiv);
    })
    

}

