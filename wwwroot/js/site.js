$('.agendamento').click(function(){
    $('.menu ul .itensAgendamento').toggleClass('mostra');
});

$('.cadastro').click(function(){
    $('.menu ul .itensCadastro').toggleClass('mostra');
});

$('.relatorios').click(function(){
    $('.menu ul .itensRelatorios').toggleClass('mostra');
});

$('.sistema').click(function(){
    $('.menu ul .itensSistema').toggleClass('mostra');
});

$('.btnMenu').click(function(){
    let btn = document.querySelector('.menu');
    btn.classList.remove('fechar');
    
    $('.menu').toggleClass('mostra');
});

$('.btnFechar').click(function(){
    $('.menu').toggleClass('fechar');
    setTimeout(function(){ 
        let btn = document.querySelector('.menu');
        btn.classList.remove('mostra');
    }, 100);
});

$( "#calendarioAgenda" ).datepicker({
    minDate: 0
  });

