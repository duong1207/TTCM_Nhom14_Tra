$(document).ready(function () {
    GetAllCustomers();
});
function GetAllCustomers() {

    $.ajax({
        url: 'https://localhost:44336/api/Sanpham', // sửa lại đường dẫn để gọi dữ liệu từ tblKhach
        method: 'GET',
        contentType: 'json',
        dataType: 'json',
        error: function (reponse) {
            alert("loi");
        },
        success: function (reponse) {
            const len = reponse.length;
            let table = '';
            for (var i = 0; i < len; ++i) {
                table = table + '<div class="col-md-4">';
                table = table + ' <div class="item__top d-flex justify-content-between">';
                table = table + ' <div class="item__top-left">';
                table = table + ' <span><i class="fas fa-star"></i></span>';
                table = table + ' <span><i class="fas fa-star"></i></span>';
                table = table + ' <span><i class="fas fa-star"></i></span>';
                table = table + ' <span><i class="fas fa-star"></i></span>';
                table = table + ' <span><i class="fas fa-star"></i></span>';
                table = table + '</div>';
                table = table + '<div class="item__top-right">';
                table = table + '<a href="#" class="btn-new">New</a>';
                table = table + ' </div>';
                table = table + '</div>';
                table = table + '<div class="item-product text-center">';
                table = table + ' <img src="../Image/' + reponse[i].AnhSP + '" alt="sp1" />  ';
                table = table + '<p><a href="../Tra/chitietsanpham?id=' + reponse[i].MaSP + '">' + reponse[i].TenSP + '</a></p>';

                table = table + '<div class="item__buttom">';
                table = table + '<span class="price">' + reponse[i].Giaban+ ' <sub> vnđ</sub > </span >';
              
                table = table + '<span class="trongluong">';

                table = table + ' <select name="khoiluong" id="khoiLuong">';
                table = table + '<option value="1">200g</option>';
                table = table + ' <option value="1">200g</option>';
                table = table + '<option value="3">500g</option>';
                table = table + '  </select>';
                table = table + '  </span>';
                table = table + '  </div>';
                table = table + '  </div>';
                table = table + '  </div>';

               
                            
                        
                   

            }
            document.getElementById('allSP').innerHTML = table;
        },
        fail: function (response) {
        }
    });
}

$(document).ready(function () {
    GetAllloaisp()

});
function GetAllloaisp() {

    $.ajax({
        url: 'https://localhost:44336/api/Loaisp', // sửa lại đường dẫn để gọi dữ liệu từ tblKhach
        method: 'GET',
        contentType: 'json',
        dataType: 'json',
        error: function (reponse) {
            alert("loi");
        },
        success: function (reponse) {
            const len = reponse.length;
            let table = '';
            for (var i = 0; i < len; ++i) {
                table = table + ' <div class="form-check">';
                table = table + '<input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">';
                table = table + '  <label class="form-check-label" for="flexCheckDefault">' + reponse[i].Tenloaisp + '</label>';
                table = table + ' </div>';


                
            }
            document.getElementById('Loaisp').innerHTML = table;
        },
        fail: function (response) {
        }
    });
}

$(document).ready(function () {
    GetAllthuonghieu()
    function GetAllthuonghieu() {

        $.ajax({
            url: 'https://localhost:44336/api/Thuonghieu', // sửa lại đường dẫn để gọi dữ liệu từ tblKhach
            method: 'GET',
            contentType: 'json',
            dataType: 'json',
            error: function (reponse) {
                alert("loi");
            },
            success: function (reponse) {
                const len = reponse.length;
                let table = '';
                for (var i = 0; i < len; ++i) {
                    table = table + ' <div class="form-check">';
                    table = table + '<input class="form-check-input" type="checkbox" value="" id="flexCheckChecked">';
                    table = table + ' <label class="form-check-label" for="flexCheckChecked">'+ reponse[i].Tenth+' </label >';
                    table = table + ' </div>';


                   

                }
                document.getElementById('Thuonghieu').innerHTML = table;
            },
            fail: function (response) {
            }
        });
    }
});


$(document).ready(function () {
    GetAllNghenhan()



    function GetAllNghenhan() {

        $.ajax({
            url: 'https://localhost:44336/api/Nghenhan', // sửa lại đường dẫn để gọi dữ liệu từ tblKhach
            method: 'GET',
            contentType: 'json',
            dataType: 'json',
            error: function (reponse) {
                alert("loi");
            },
            success: function (reponse) {
                const len = reponse.length;
                let table = '';
                for (var i = 0; i < len; ++i) {
                    table = table + '<li class="tea-artist__item">';
                    table = table + ' <img src="../Image/' + reponse[i].AnhNN + '" alt=""class="tea-artist__img" />';

                    
                    table = table + '<h4 class="tea-artist__name">' + reponse[i].Tennghenhan + '</h4>';
                    table = table + '<p class="tea-artist__desc">' + reponse[i].Thongtin + '</p >';
                    table = table + '</li>';
                }


                document.getElementById('Nghenhan').innerHTML = table;
            },
            fail: function (response) {
            }
        });
    }
});


$(document).ready(function () {
    GetAllTintuc()
    function GetAllTintuc() {

        $.ajax({
            url: 'https://localhost:44336/api/Tintuc', // sửa lại đường dẫn để gọi dữ liệu từ tblKhach
            method: 'GET',
            contentType: 'json',
            dataType: 'json',
            error: function (reponse) {
                alert("loi");
            },
            success: function (reponse) {
                const len = reponse.length;
                let table = '';
                for (var i = 0; i < len; ++i) {
                    table = table + ' <div class="col-md-4 col-sm-6 col-12">';
                    table = table + '<div class="item">';
                    table = table + '<a href="../Tra/baiviet?id=' + reponse[i].MaTT + '">' + ' <img src="../Image/' + reponse[i].AnhTT + '" alt="">';
                    table = table + '<a href="../Tra/baiviet?id=' + reponse[i].MaTT + '">' + reponse[i].Tieude + '</a>';
                    table = table + ' <p>' + reponse[i].Gioithieu +'</p>';
                    table = table + ' </div>';
                    table = table + ' </div>';




                }
                document.getElementById('Tintuc').innerHTML = table;
            },
            fail: function (response) {
            }
        });
    }
});





               