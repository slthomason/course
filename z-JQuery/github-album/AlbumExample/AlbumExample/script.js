const USERS_PER_PAGE = 20;
let currentPage = 1;
let totalUsers = 0;

$(document).ready(function() {
    fetchUsers(currentPage);

    function fetchUsers(page) {
        $.ajax({
            url: `https://api.github.com/users?since=${(page - 1) * USERS_PER_PAGE}`,
            method: 'GET',
            success: function(data) {
                totalUsers = data.length; // Get the number of users fetched
                console.log(data);
                // renderUsers(data);
                // renderPagination();
            },
            error: function() {
                alert('Failed to fetch users.');
            }
        });
    }

    // function renderUsers(users) {
    //     $('#user-cards').empty();
    //     users.forEach(user => {
    //         $('#user-cards').append(`
    //             <div class="col-md-3">
    //                 <div class="user-card">
    //                     <img src="${user.avatar_url}" alt="${user.login}" class="img-fluid">
    //                     <h5>${user.login}</h5>
    //                     <p><a href="${user.html_url}" target="_blank">Profile</a></p>
    //                 </div>
    //             </div>
    //         `);
    //     });
    // }

    // function renderPagination() {
    //     const totalPages = Math.ceil(totalUsers / USERS_PER_PAGE);
    //     $('#pagination').empty();

    //     for (let i = 1; i <= totalPages; i++) {
    //         $('#pagination').append(`
    //             <li class="page-item ${i === currentPage ? 'active' : ''}">
    //                 <a class="page-link" href="#" data-page="${i}">${i}</a>
    //             </li>
    //         `);
    //     }

    //     $('.page-link').click(function(e) {
    //         e.preventDefault();
    //         currentPage = $(this).data('page');
    //         fetchUsers(currentPage);
    //     });
    // }
});
