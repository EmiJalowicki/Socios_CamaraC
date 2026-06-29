-- MIGRACION DE CUOTAS PAGAS DESDE NOV 2025
BEGIN TRANSACTION;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 201
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 2754
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5254
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 2988
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3550
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4233
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3199
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 2630
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3583
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5341
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4522
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 267
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 951
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 2544
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5262
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4421
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4827
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 1159
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 918
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3066
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5370
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 2689
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3197
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5295
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4559
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4559
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5249
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3140
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3140
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4448
  AND Periodo = '2025-09-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4448
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4448
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3309
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3309
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3526
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 1594
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3134
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5405
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3501
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 2794
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3105
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4573
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3326
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5320
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4446
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5328
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3983
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4418
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4056
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4507
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3576
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 1751
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4856
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4856
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3673
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5415
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4498
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3384
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5389
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 282
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 2870
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 1952
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5249
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 208
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5168
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4475
  AND Periodo = '2025-09-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4475
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4475
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3078
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3078
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3344
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5313
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4850
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 1510
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5199
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 864
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 2545
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4635
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 261
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3829
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 305
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5045
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5172
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 971
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 2963
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 2963
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 668
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 43
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3656
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5331
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5331
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4705
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4705
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 579
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 579
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4724
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5273
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3483
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 19
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 841
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 1353
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5451
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4619
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4541
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 609
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4991
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4388
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4808
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3678
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4744
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3593
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 585
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4267
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 1719
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 447
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 1926
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4380
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4732
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3839
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 2410
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5408
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3821
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 1153
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3099
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3629
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3629
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3916
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3916
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3421
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5301
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 284
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3188
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3163
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3890
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4290
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5318
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4950
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5382
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4762
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4789
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5375
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5085
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4227
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4461
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4461
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 264
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3508
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 2589
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 79
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 125
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4968
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5450
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4282
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3143
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4425
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4425
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5133
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5189
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5453
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 83
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5139
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5139
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 115
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 935
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4166
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3138
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3338
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5454
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5353
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5369
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5152
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 53
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4743
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3525
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3019
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 795
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3760
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3491
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5311
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5311
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4628
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4628
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5363
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5165
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 3544
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 5135
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4650
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-01'
WHERE NumSocio = 4945
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 932
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 932
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 813
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 3017
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 4147
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 5207
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 5448
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 4803
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 129
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 129
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 247
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 247
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 4557
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 4557
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 2639
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 2639
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 3522
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 3688
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 2684
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 4245
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 4930
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 4534
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 3112
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 3861
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 3861
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 326
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 5452
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 1751
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 1565
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 3410
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 2581
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 1903
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 4664
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 4214
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 25
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 3104
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 5378
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 2177
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 3230
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 2479
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 3954
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 4759
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 4403
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 4403
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 3811
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 5346
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 1
  AND Periodo = '2025-09-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 1
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 1
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 3559
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-11-17'
WHERE NumSocio = 4659
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 201
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2754
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5254
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2988
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3550
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4856
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4388
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3916
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 935
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5363
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 129
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 247
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4930
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 1751
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2581
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 25
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3066
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2177
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2479
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4403
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2689
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3421
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4446
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 918
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3751
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3544
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4559
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4507
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5341
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3559
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3199
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4233
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4557
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2630
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 135
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 840
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 840
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5429
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5429
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5429
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2544
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 1594
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3326
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4808
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 585
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3217
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3501
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2410
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3576
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 267
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5450
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4147
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 305
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3134
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2852
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2852
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 42
  AND Periodo = '2025-08-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 42
  AND Periodo = '2025-09-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 42
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 42
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4850
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3526
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 951
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3143
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4573
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5313
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4056
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 1153
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3821
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3163
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3890
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3983
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4421
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3656
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 668
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2963
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3197
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4019
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3688
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3384
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5320
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5405
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4498
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2870
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3483
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3593
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 1510
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2545
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3105
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2794
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4724
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3583
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4282
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 971
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5451
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 43
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4619
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4945
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 208
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4991
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3876
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3876
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 283
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 283
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4267
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5262
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3344
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 282
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3829
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5199
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3309
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3839
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4732
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5328
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5455
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5173
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5173
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5173
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5173
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5168
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 83
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4393
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5453
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5133
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4322
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4322
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5273
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 1159
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4290
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4968
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4522
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3230
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5207
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 261
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5318
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 813
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5301
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3099
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4664
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 1952
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5382
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4744
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5408
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4635
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5375
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3138
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 609
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3508
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3188
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5311
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4166
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2639
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5045
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 1719
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 447
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 284
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5415
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4418
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2414
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2414
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5189
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5152
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4541
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 1031
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 1031
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 1031
  AND Periodo = '2025-09-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 1031
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5295
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3046
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3046
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3046
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3338
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 115
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4950
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3019
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5172
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4743
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4862
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4862
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4972
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4972
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3678
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4762
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3017
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 1535
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5135
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4650
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 5085
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 2684
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 4461
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 53
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-01'
WHERE NumSocio = 3491
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 4289
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 4289
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5267
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5267
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5331
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5454
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5448
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 1353
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5389
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 2589
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 3760
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 1975
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 1975
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 79
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 125
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 579
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 841
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 1903
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5370
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 3410
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 932
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 3522
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 795
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 3112
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 3861
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 244
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 244
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 16
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 16
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5452
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5369
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5346
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 4245
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 264
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 3525
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5378
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 3811
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 4534
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 3104
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5456
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5457
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5458
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5165
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 4789
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 4214
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 3954
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 1565
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 3876
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5392
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5392
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 135
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 135
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 3647
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 3692
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 3692
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 767
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5215
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5215
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2025-12-15'
WHERE NumSocio = 5215
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4056
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 2544
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 1926
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4380
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3066
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5459
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4421
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3501
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 208
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3197
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5295
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5353
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5353
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4759
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4759
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4227
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4227
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3230
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 1975
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 1594
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 918
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 1159
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5389
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 447
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5313
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 951
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3326
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3140
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4214
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3099
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3188
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 2410
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3576
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 2794
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5405
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3688
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 2581
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4732
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 2754
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4850
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5457
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 267
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5045
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4724
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 43
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5435
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4322
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4388
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3483
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5460
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4808
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4446
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5458
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3829
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3550
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4507
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 282
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 261
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5320
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 1952
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5262
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4147
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4991
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5168
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 668
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4393
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5451
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5189
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3217
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3593
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3384
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3344
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3821
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3309
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3421
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4664
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3138
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3143
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 1510
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3760
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5152
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5133
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3656
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 795
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 813
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4619
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 935
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3163
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3890
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4418
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 2963
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5453
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 264
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5409
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3941
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3941
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3941
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 864
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 864
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3526
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5273
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5450
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4282
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 840
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5207
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 2545
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4950
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5382
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5375
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5172
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 585
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4019
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3019
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5085
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3199
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4945
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4541
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 609
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 1589
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 2988
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3678
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4762
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5328
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5267
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4650
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4789
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 1153
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5461
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3508
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 2684
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4166
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 2639
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 2689
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5311
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 83
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 53
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 1719
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5199
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 2870
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5408
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4743
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3491
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3673
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3673
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 932
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3954
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5135
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5346
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5301
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3104
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 2589
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3916
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 4534
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3410
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5341
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3112
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5448
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 971
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 5254
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-01'
WHERE NumSocio = 3861
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 3983
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 5318
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 3522
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4289
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 5369
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4827
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 201
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 25
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4930
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4267
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 2852
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4233
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4245
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 5363
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 3525
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 1565
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 5454
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4461
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4628
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4628
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 3839
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4862
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4968
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4290
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 115
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 5249
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 3123
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4088
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 3751
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 284
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 5303
  AND Periodo = '2025-10-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 5303
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 5249
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4856
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 5378
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 305
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 5331
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 3017
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 767
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 3559
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 1353
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 2177
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 129
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 247
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4557
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 1903
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 3629
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 3629
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4371
  AND Periodo = '2025-11-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4371
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4371
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4559
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 579
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4744
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4425
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-01-19'
WHERE NumSocio = 4425
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 2754
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 1589
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 2988
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3916
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 201
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4930
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4088
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3647
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4322
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4056
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4388
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 2689
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3066
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 25
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5363
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 2544
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4856
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 2581
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3421
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 767
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 585
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3559
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 2177
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 840
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5450
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3501
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 1719
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3230
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 579
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3550
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4446
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4421
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4380
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 1926
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 1692
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 1692
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4233
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3199
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4461
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4425
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3197
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3105
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3134
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3134
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5139
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5139
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3046
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3046
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 2794
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5369
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4289
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5328
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 935
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5320
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5459
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3593
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 208
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3583
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3583
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5262
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3576
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5457
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5085
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3344
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4850
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5346
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5462
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4147
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5168
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 668
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4393
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5370
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5370
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3829
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3384
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3326
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3410
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3821
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5389
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3483
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5451
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4403
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4403
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4498
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4498
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 841
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 841
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 281
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 281
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 281
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4808
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 864
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 2545
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4267
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3099
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5405
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 282
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4619
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3143
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5045
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 43
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 609
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4522
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4522
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3707
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3707
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 971
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 1952
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5454
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 1159
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 261
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3140
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4724
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4732
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4166
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 2852
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 813
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 951
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3839
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3017
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4827
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 83
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5133
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5453
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5415
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5415
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4762
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5382
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 795
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4789
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4282
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5172
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3019
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3890
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3163
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4945
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4743
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5152
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3491
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4862
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3587
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3587
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 284
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 447
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 305
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4290
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5207
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3138
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5267
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4628
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 115
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3188
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5135
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4418
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3525
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5273
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5408
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5375
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4019
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4950
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5313
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 1510
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3656
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 264
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 53
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4991
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5173
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5189
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 2589
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3508
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3104
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 4650
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 2639
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 1353
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3526
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 3078
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 5341
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-01'
WHERE NumSocio = 2870
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 2630
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 2630
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 3861
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 2684
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 1975
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 932
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 3678
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 5295
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 1594
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 5448
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 3522
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 1565
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 5392
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 5392
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 4803
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 4803
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 4803
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 4541
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 3760
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 1535
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 1535
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 1903
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 5378
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 5165
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 4759
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 4214
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 2963
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-02-16'
WHERE NumSocio = 3954
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3647
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4088
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4930
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 2754
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 1589
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 2988
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3916
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 201
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3559
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3230
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4322
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3066
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4862
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3707
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4233
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4425
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3587
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5463
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5464
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5459
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5346
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 951
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4421
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3501
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4446
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 2794
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 2639
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 447
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3134
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3105
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 208
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3197
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 918
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 918
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4227
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4227
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 135
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 135
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4507
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4507
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4559
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4559
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 585
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5389
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3217
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 1952
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 282
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5405
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5320
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4056
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5369
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 767
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4732
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3140
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 1594
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 2544
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5313
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 668
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4019
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3384
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3326
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 2545
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 261
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5450
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3983
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 1510
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4267
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5262
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3876
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3491
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5168
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5451
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 1153
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 1153
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3688
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3688
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4282
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3143
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4619
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5273
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3344
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 1975
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 1719
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 1159
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3839
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4724
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3656
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5173
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5249
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4744
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3629
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3629
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3309
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3309
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3673
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3673
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3338
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3338
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3338
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 19
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 19
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 19
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 813
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4808
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4850
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4762
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3829
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5311
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4289
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4147
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5341
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5457
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 2870
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 935
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 2693
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 840
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4498
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 609
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 43
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5295
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4573
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4573
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5318
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5318
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5301
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5301
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5215
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5215
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5215
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4388
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3593
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3483
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 305
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3104
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3526
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4827
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3188
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 2581
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5045
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4380
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 1926
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5458
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4418
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5408
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5375
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 932
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4803
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 264
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3508
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4393
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5331
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5331
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5308
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5308
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5308
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3821
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3550
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5464
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3576
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3099
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3583
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5139
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 971
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3199
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4461
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4541
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5199
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5199
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4705
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4705
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3941
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3941
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 864
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3138
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4166
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 284
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5454
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5328
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4950
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 115
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4650
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3421
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3410
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5152
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4991
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5133
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5189
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5453
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 2479
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 2479
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 2479
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5353
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5353
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5172
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4403
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5267
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3163
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3890
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5207
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5135
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 5085
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3525
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4945
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4635
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4635
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4664
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 1535
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 1353
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3019
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 3046
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 4743
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-01'
WHERE NumSocio = 2684
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 16
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 16
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 16
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 3078
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 3078
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5448
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5465
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 3678
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 211
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 211
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 211
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5382
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 1031
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 1031
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 1031
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 4968
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 267
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 326
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 83
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 3751
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 3751
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 4290
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 3861
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5303
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5303
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5303
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 4534
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 4534
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 25
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 3017
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 4245
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5214
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5214
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 3522
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 4789
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 795
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5392
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5370
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 2177
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 3112
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 1565
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5378
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5249
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5388
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 3078
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 2414
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 2414
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 3760
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 42
  AND Periodo = '2025-12-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 42
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 42
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 42
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 4744
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 1903
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 2689
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 3811
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 53
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 5295
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-03-16'
WHERE NumSocio = 4522
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4388
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 201
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5464
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3066
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 25
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3559
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 2544
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3421
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 2689
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3501
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 1975
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5199
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 267
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 1594
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4267
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3576
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5466
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3199
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3197
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4088
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3587
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4056
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 1589
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3647
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3707
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3916
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 211
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4930
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 2754
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5308
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 1719
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3140
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4732
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4371
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4371
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3134
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5450
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3326
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4446
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4507
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 2545
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 951
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4724
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 305
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 609
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4421
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3526
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5331
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5313
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 918
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5273
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 19
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 264
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4705
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3839
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4808
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5405
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3137
  AND Periodo = '2026-01-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3137
  AND Periodo = '2026-02-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3137
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3137
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3099
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5320
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3760
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4019
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 2581
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5311
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 1952
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5353
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4850
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4759
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5457
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4147
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 83
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3483
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3188
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4827
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5168
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5415
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5415
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 2630
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 2630
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 864
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5459
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3230
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4166
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3829
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4541
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5458
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5454
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4498
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 208
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 841
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 841
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 668
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4635
  AND Periodo = '2026-03-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3593
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3751
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4282
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 2235
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 2794
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 3105
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 971
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 4991
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '2026-04-01'
WHERE NumSocio = 5451
  AND Periodo = '2026-04-01'
  AND EstaPaga = 0;

COMMIT;
