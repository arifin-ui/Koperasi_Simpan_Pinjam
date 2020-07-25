-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 13, 2020 at 04:54 AM
-- Server version: 10.3.16-MariaDB
-- PHP Version: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `simpanpinjam`
--

-- --------------------------------------------------------

--
-- Table structure for table `anggota`
--

CREATE TABLE `anggota` (
  `id_anggota` varchar(10) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `alamat` text NOT NULL,
  `tgl_lahir` varchar(50) NOT NULL,
  `tempat_lahir` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(15) NOT NULL,
  `status` varchar(15) NOT NULL,
  `no_telepon` varchar(15) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `anggota`
--

INSERT INTO `anggota` (`id_anggota`, `nama`, `alamat`, `tgl_lahir`, `tempat_lahir`, `jenis_kelamin`, `status`, `no_telepon`, `keterangan`) VALUES
('A0001', 'Haji munif', 'sukoharjo,RT/RW :005/009', '07 February 1980', 'wonosobo', 'Laki-laki', 'Menikah', '089098342657', 'anggota'),
('A0002', 'Markonah', 'Kalilawang', '06 July 1989', 'wonosobo', 'Perempuan', 'Menikah', '087980123487', 'anggota 1');

-- --------------------------------------------------------

--
-- Table structure for table `angsuran`
--

CREATE TABLE `angsuran` (
  `id_angsuran` varchar(10) NOT NULL,
  `id_kategori` varchar(10) NOT NULL,
  `id_anggota` varchar(10) NOT NULL,
  `tgl_pembayaran` varchar(50) NOT NULL,
  `angsuran_ke` varchar(15) NOT NULL,
  `besar_angsuran` int(11) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `angsuran`
--

INSERT INTO `angsuran` (`id_angsuran`, `id_kategori`, `id_anggota`, `tgl_pembayaran`, `angsuran_ke`, `besar_angsuran`, `keterangan`) VALUES
('ANG001', 'P0001', 'A0001', '09 February 2020', '1', 200000, 'tunai');

-- --------------------------------------------------------

--
-- Table structure for table `detail_angsuran`
--

CREATE TABLE `detail_angsuran` (
  `id_angsuran` varchar(10) NOT NULL,
  `tgl_jatuh_tempo` varchar(50) NOT NULL,
  `besar_angsuran` int(11) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detail_angsuran`
--

INSERT INTO `detail_angsuran` (`id_angsuran`, `tgl_jatuh_tempo`, `besar_angsuran`, `keterangan`) VALUES
('ANG001', '09 February 2020', 200000, 'tunai');

-- --------------------------------------------------------

--
-- Table structure for table `kategori_pinjaman`
--

CREATE TABLE `kategori_pinjaman` (
  `id_kategori_pinjaman` varchar(10) NOT NULL,
  `nama_pinjaman` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kategori_pinjaman`
--

INSERT INTO `kategori_pinjaman` (`id_kategori_pinjaman`, `nama_pinjaman`) VALUES
('P0001', 'pinjaman kilat'),
('P0002', 'pinjaman jangka panjang'),
('P0003', 'pinjaman jangka menengah');

-- --------------------------------------------------------

--
-- Table structure for table `petugas`
--

CREATE TABLE `petugas` (
  `id_petugas` varchar(10) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `alamat` text NOT NULL,
  `no_telepon` varchar(15) NOT NULL,
  `tempat_lahir` varchar(50) NOT NULL,
  `tgl_lahir` varchar(50) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `petugas`
--

INSERT INTO `petugas` (`id_petugas`, `nama`, `username`, `password`, `alamat`, `no_telepon`, `tempat_lahir`, `tgl_lahir`, `keterangan`) VALUES
('P0001', 'febi arifin', 'febi', '123', 'siwads rt 4 ,rw 3', '089765423546', 'wonosobo', '23', 'petugas 1'),
('P0002', 'Siti maimunah', 'siti', '3456', 'gondang, watumalang', '088865223569', 'wonosobo', '12', 'petugas2'),
('P0003', 'petugas koperasi', 'petugas', '1', 'smk taq wsb ', '089765423546', 'wonosobo', '31', 'petugas tetap');

-- --------------------------------------------------------

--
-- Table structure for table `pinjaman`
--

CREATE TABLE `pinjaman` (
  `id_pinjaman` varchar(10) NOT NULL,
  `nama_pinjaman` varchar(255) NOT NULL,
  `id_anggota` varchar(10) NOT NULL,
  `besar_pinjaman` int(11) NOT NULL,
  `tgl_pengajuan_pinjaman` varchar(50) NOT NULL,
  `tgl_acc_pinjaman` varchar(50) NOT NULL,
  `tgl_pinjaman` varchar(50) NOT NULL,
  `tgl_pelunasan` varchar(50) NOT NULL,
  `id_angsuran` varchar(10) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pinjaman`
--

INSERT INTO `pinjaman` (`id_pinjaman`, `nama_pinjaman`, `id_anggota`, `besar_pinjaman`, `tgl_pengajuan_pinjaman`, `tgl_acc_pinjaman`, `tgl_pinjaman`, `tgl_pelunasan`, `id_angsuran`, `keterangan`) VALUES
('P0001', 'pinjaman kilat', 'A0001', 20000000, '09 February 2020', '12 February 2020', '12 February 2020', '07 March 2020', 'ANG001', 'cicil');

-- --------------------------------------------------------

--
-- Table structure for table `simpanan`
--

CREATE TABLE `simpanan` (
  `id_simpanan` varchar(10) NOT NULL,
  `nama_simpanan` varchar(255) NOT NULL,
  `id_anggota` varchar(10) NOT NULL,
  `tgl_simpanan` varchar(50) NOT NULL,
  `besar_simpanan` int(11) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `simpanan`
--

INSERT INTO `simpanan` (`id_simpanan`, `nama_simpanan`, `id_anggota`, `tgl_simpanan`, `besar_simpanan`, `keterangan`) VALUES
('S0001', 'Simpanan masa depan', 'A0001', '09 February 2020', 15000000, 'tunai');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `anggota`
--
ALTER TABLE `anggota`
  ADD PRIMARY KEY (`id_anggota`);

--
-- Indexes for table `angsuran`
--
ALTER TABLE `angsuran`
  ADD PRIMARY KEY (`id_angsuran`);

--
-- Indexes for table `detail_angsuran`
--
ALTER TABLE `detail_angsuran`
  ADD PRIMARY KEY (`id_angsuran`);

--
-- Indexes for table `kategori_pinjaman`
--
ALTER TABLE `kategori_pinjaman`
  ADD PRIMARY KEY (`id_kategori_pinjaman`);

--
-- Indexes for table `petugas`
--
ALTER TABLE `petugas`
  ADD PRIMARY KEY (`id_petugas`);

--
-- Indexes for table `pinjaman`
--
ALTER TABLE `pinjaman`
  ADD PRIMARY KEY (`id_pinjaman`);

--
-- Indexes for table `simpanan`
--
ALTER TABLE `simpanan`
  ADD PRIMARY KEY (`id_simpanan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
