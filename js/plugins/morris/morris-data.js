$(function() {

    Morris.Area({
        element: 'morris-area-chart',
        data: [{
			    period: '2010 Hurling Final',
             
		  LEINSTER: 22,
            MUNSTER: 19,
       ULSTER: 26
			   
           
        },  {
			   period: '2011 Hurling Final',
            LEINSTER: 33,
            MUNSTER: 40,
              ULSTER: 37
			
        }, {
            period: '2012 Hurling Final',
            LEINSTER: 27,
            MUNSTER: 23,
            ULSTER: 27
        }, {
           period: '2013 Hurling Final',
            LEINSTER: 31,
            MUNSTER: 24,
            ULSTER: null
        }, {
            period: '2014 Hurling Final',
            LEINSTER: 24,
            MUNSTER: 30,
            ULSTER: 23
        }],
        xkey: 'period',
        ykeys: ['LEINSTER', 'MUNSTER', 'ULSTER'],
        labels: ['LEINSTER Winner Points', 'MUNSTER Winner Points', 'ULSTER Winner Points'],
        pointSize: 2,
        hideHover: 'auto',
        resize: true
    });

   
   

});
