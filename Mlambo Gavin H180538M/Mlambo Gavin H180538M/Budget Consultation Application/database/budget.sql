-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 09, 2022 at 08:40 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `budget`
--

-- --------------------------------------------------------

--
-- Table structure for table `auth_group`
--

CREATE TABLE `auth_group` (
  `id` int(11) NOT NULL,
  `name` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `auth_group_permissions`
--

CREATE TABLE `auth_group_permissions` (
  `id` bigint(20) NOT NULL,
  `group_id` int(11) NOT NULL,
  `permission_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `auth_permission`
--

CREATE TABLE `auth_permission` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `content_type_id` int(11) NOT NULL,
  `codename` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `auth_permission`
--

INSERT INTO `auth_permission` (`id`, `name`, `content_type_id`, `codename`) VALUES
(1, 'Can add log entry', 1, 'add_logentry'),
(2, 'Can change log entry', 1, 'change_logentry'),
(3, 'Can delete log entry', 1, 'delete_logentry'),
(4, 'Can view log entry', 1, 'view_logentry'),
(5, 'Can add permission', 2, 'add_permission'),
(6, 'Can change permission', 2, 'change_permission'),
(7, 'Can delete permission', 2, 'delete_permission'),
(8, 'Can view permission', 2, 'view_permission'),
(9, 'Can add group', 3, 'add_group'),
(10, 'Can change group', 3, 'change_group'),
(11, 'Can delete group', 3, 'delete_group'),
(12, 'Can view group', 3, 'view_group'),
(13, 'Can add user', 4, 'add_user'),
(14, 'Can change user', 4, 'change_user'),
(15, 'Can delete user', 4, 'delete_user'),
(16, 'Can view user', 4, 'view_user'),
(17, 'Can add content type', 5, 'add_contenttype'),
(18, 'Can change content type', 5, 'change_contenttype'),
(19, 'Can delete content type', 5, 'delete_contenttype'),
(20, 'Can view content type', 5, 'view_contenttype'),
(21, 'Can add session', 6, 'add_session'),
(22, 'Can change session', 6, 'change_session'),
(23, 'Can delete session', 6, 'delete_session'),
(24, 'Can view session', 6, 'view_session'),
(25, 'Can add unwanted words', 7, 'add_unwantedwords'),
(26, 'Can change unwanted words', 7, 'change_unwantedwords'),
(27, 'Can delete unwanted words', 7, 'delete_unwantedwords'),
(28, 'Can view unwanted words', 7, 'view_unwantedwords'),
(29, 'Can add block contacts', 8, 'add_blockcontacts'),
(30, 'Can change block contacts', 8, 'change_blockcontacts'),
(31, 'Can delete block contacts', 8, 'delete_blockcontacts'),
(32, 'Can view block contacts', 8, 'view_blockcontacts'),
(33, 'Can add rates comments', 9, 'add_ratescomments'),
(34, 'Can change rates comments', 9, 'change_ratescomments'),
(35, 'Can delete rates comments', 9, 'delete_ratescomments'),
(36, 'Can view rates comments', 9, 'view_ratescomments'),
(37, 'Can add tarrifs', 10, 'add_tarrifs'),
(38, 'Can change tarrifs', 10, 'change_tarrifs'),
(39, 'Can delete tarrifs', 10, 'delete_tarrifs'),
(40, 'Can view tarrifs', 10, 'view_tarrifs'),
(41, 'Can add projects', 11, 'add_projects'),
(42, 'Can change projects', 11, 'change_projects'),
(43, 'Can delete projects', 11, 'delete_projects'),
(44, 'Can view projects', 11, 'view_projects'),
(45, 'Can add profile', 12, 'add_profile'),
(46, 'Can change profile', 12, 'change_profile'),
(47, 'Can delete profile', 12, 'delete_profile'),
(48, 'Can view profile', 12, 'view_profile'),
(49, 'Can add view user', 13, 'add_viewuser'),
(50, 'Can change view user', 13, 'change_viewuser'),
(51, 'Can delete view user', 13, 'delete_viewuser'),
(52, 'Can view view user', 13, 'view_viewuser'),
(53, 'Can add price', 14, 'add_price'),
(54, 'Can change price', 14, 'change_price'),
(55, 'Can delete price', 14, 'delete_price'),
(56, 'Can view price', 14, 'view_price'),
(57, 'Can add request item', 15, 'add_requestitem'),
(58, 'Can change request item', 15, 'change_requestitem'),
(59, 'Can delete request item', 15, 'delete_requestitem'),
(60, 'Can view request item', 15, 'view_requestitem');

-- --------------------------------------------------------

--
-- Table structure for table `auth_user`
--

CREATE TABLE `auth_user` (
  `id` int(11) NOT NULL,
  `password` varchar(128) NOT NULL,
  `last_login` datetime(6) DEFAULT NULL,
  `is_superuser` tinyint(1) NOT NULL,
  `username` varchar(150) NOT NULL,
  `first_name` varchar(150) NOT NULL,
  `last_name` varchar(150) NOT NULL,
  `email` varchar(254) NOT NULL,
  `is_staff` tinyint(1) NOT NULL,
  `is_active` tinyint(1) NOT NULL,
  `date_joined` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `auth_user`
--

INSERT INTO `auth_user` (`id`, `password`, `last_login`, `is_superuser`, `username`, `first_name`, `last_name`, `email`, `is_staff`, `is_active`, `date_joined`) VALUES
(1, 'pbkdf2_sha256$320000$qFk6GU45z5cGv5WZOGltJ8$cGW4BMeOBfDsvMy/eJnOixSb+1wsnWQVF5WF+TbDnv8=', '2022-06-03 06:30:31.925860', 0, '04-177740W04', 'Mlambo', 'Gavin', 'huro@huro.com', 0, 1, '2022-05-30 10:51:52.086973'),
(2, 'pbkdf2_sha256$320000$E1H90MoJ8zqzUPSGsdpxWy$snYwxwsPkI9rv5SqksEUShQnG+eiWNQSwO7DZaa/idI=', '2022-06-03 05:18:19.223591', 1, 'Huro', '', '', 'huro@huro.com', 1, 1, '2022-05-30 10:53:33.819871'),
(3, 'pbkdf2_sha256$320000$rKbIbxaIbJuUn9UsLr2YQf$wH5TUycEHTwHl/vDjvchDputxY9Zt+WnBcXkXk5pDsM=', '2022-06-03 06:36:19.611076', 0, 'Mlambo', '', '', '', 1, 1, '2022-05-30 11:18:48.000000'),
(4, 'pbkdf2_sha256$320000$M7rhSenUwMlbT8QQ69E58Q$DQYQyIywii/t8rbxBpoqyZREgb2e75Nc6wpGV/5Lckk=', NULL, 1, 'Brendon', 'Chipoyi', 'Brendoo', 'george@c.co', 0, 1, '2022-05-30 13:29:23.710575');

-- --------------------------------------------------------

--
-- Table structure for table `auth_user_groups`
--

CREATE TABLE `auth_user_groups` (
  `id` bigint(20) NOT NULL,
  `user_id` int(11) NOT NULL,
  `group_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `auth_user_user_permissions`
--

CREATE TABLE `auth_user_user_permissions` (
  `id` bigint(20) NOT NULL,
  `user_id` int(11) NOT NULL,
  `permission_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `django_admin_log`
--

CREATE TABLE `django_admin_log` (
  `id` int(11) NOT NULL,
  `action_time` datetime(6) NOT NULL,
  `object_id` longtext DEFAULT NULL,
  `object_repr` varchar(200) NOT NULL,
  `action_flag` smallint(5) UNSIGNED NOT NULL CHECK (`action_flag` >= 0),
  `change_message` longtext NOT NULL,
  `content_type_id` int(11) DEFAULT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `django_admin_log`
--

INSERT INTO `django_admin_log` (`id`, `action_time`, `object_id`, `object_repr`, `action_flag`, `change_message`, `content_type_id`, `user_id`) VALUES
(1, '2022-05-30 10:54:45.793457', '1', 'General Dealer  1000.0   2022-05-30 10:54:34+00:00  Price too highHuro', 1, '[{\"added\": {}}]', 10, 2),
(2, '2022-05-30 11:01:57.481743', '1', 'fuck', 1, '[{\"added\": {}}]', 7, 2),
(3, '2022-05-30 11:02:11.853710', '2', 'uri imbwa', 1, '[{\"added\": {}}]', 7, 2),
(4, '2022-05-30 11:02:25.126597', '3', 'dhoti', 1, '[{\"added\": {}}]', 7, 2),
(5, '2022-05-30 11:02:47.537290', '4', 'imbwa', 1, '[{\"added\": {}}]', 7, 2),
(6, '2022-05-30 11:05:53.310816', '1', 'School12.0 2000', 1, '[{\"added\": {}}]', 11, 2),
(7, '2022-05-30 11:06:17.207895', '2', 'Road Maintenance100.0 2001', 1, '[{\"added\": {}}]', 11, 2),
(8, '2022-05-30 11:18:48.947945', '3', 'Mlambo', 1, '[{\"added\": {}}]', 4, 2),
(9, '2022-05-30 11:19:02.062842', '3', 'Mlambo', 2, '[{\"changed\": {\"fields\": [\"Staff status\"]}}]', 4, 2),
(10, '2022-05-30 11:40:47.565012', '1', 'Chair  50.0', 1, '[{\"added\": {}}]', 14, 2),
(11, '2022-05-30 11:41:01.520859', '2', 'tables  1000.0', 1, '[{\"added\": {}}]', 14, 2),
(12, '2022-05-30 11:41:27.979847', '3', 'Keyboard  10.0', 1, '[{\"added\": {}}]', 14, 2),
(13, '2022-05-30 11:56:41.067776', '1', '2  20', 2, '[]', 15, 2),
(14, '2022-05-30 12:14:58.178873', '4', 'books  1.3', 1, '[{\"added\": {}}]', 14, 2),
(15, '2022-05-30 12:15:25.447104', '5', 'Monitor  500.0', 1, '[{\"added\": {}}]', 14, 2),
(16, '2022-05-30 12:15:40.743683', '6', 'Laptop  1000.0', 1, '[{\"added\": {}}]', 14, 2),
(17, '2022-05-30 12:16:15.534202', '7', 'power adapters  200.0', 1, '[{\"added\": {}}]', 14, 2),
(18, '2022-05-30 13:28:06.107200', '1', '04-177740W04   2022-05-30 11:03:07.461458+00:00', 3, '', 8, 2);

-- --------------------------------------------------------

--
-- Table structure for table `django_content_type`
--

CREATE TABLE `django_content_type` (
  `id` int(11) NOT NULL,
  `app_label` varchar(100) NOT NULL,
  `model` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `django_content_type`
--

INSERT INTO `django_content_type` (`id`, `app_label`, `model`) VALUES
(1, 'admin', 'logentry'),
(3, 'auth', 'group'),
(2, 'auth', 'permission'),
(4, 'auth', 'user'),
(5, 'contenttypes', 'contenttype'),
(6, 'sessions', 'session'),
(8, 'users', 'blockcontacts'),
(14, 'users', 'price'),
(12, 'users', 'profile'),
(11, 'users', 'projects'),
(9, 'users', 'ratescomments'),
(15, 'users', 'requestitem'),
(10, 'users', 'tarrifs'),
(7, 'users', 'unwantedwords'),
(13, 'users', 'viewuser');

-- --------------------------------------------------------

--
-- Table structure for table `django_migrations`
--

CREATE TABLE `django_migrations` (
  `id` bigint(20) NOT NULL,
  `app` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `applied` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `django_migrations`
--

INSERT INTO `django_migrations` (`id`, `app`, `name`, `applied`) VALUES
(1, 'contenttypes', '0001_initial', '2022-05-30 10:49:18.298899'),
(2, 'auth', '0001_initial', '2022-05-30 10:49:31.215250'),
(3, 'admin', '0001_initial', '2022-05-30 10:49:34.032945'),
(4, 'admin', '0002_logentry_remove_auto_add', '2022-05-30 10:49:34.092299'),
(5, 'admin', '0003_logentry_add_action_flag_choices', '2022-05-30 10:49:34.148006'),
(6, 'contenttypes', '0002_remove_content_type_name', '2022-05-30 10:49:35.057881'),
(7, 'auth', '0002_alter_permission_name_max_length', '2022-05-30 10:49:35.999984'),
(8, 'auth', '0003_alter_user_email_max_length', '2022-05-30 10:49:36.147830'),
(9, 'auth', '0004_alter_user_username_opts', '2022-05-30 10:49:36.208235'),
(10, 'auth', '0005_alter_user_last_login_null', '2022-05-30 10:49:37.363801'),
(11, 'auth', '0006_require_contenttypes_0002', '2022-05-30 10:49:37.447218'),
(12, 'auth', '0007_alter_validators_add_error_messages', '2022-05-30 10:49:37.540399'),
(13, 'auth', '0008_alter_user_username_max_length', '2022-05-30 10:49:37.785707'),
(14, 'auth', '0009_alter_user_last_name_max_length', '2022-05-30 10:49:38.077476'),
(15, 'auth', '0010_alter_group_name_max_length', '2022-05-30 10:49:38.770246'),
(16, 'auth', '0011_update_proxy_permissions', '2022-05-30 10:49:38.820605'),
(17, 'auth', '0012_alter_user_first_name_max_length', '2022-05-30 10:49:38.964703'),
(18, 'sessions', '0001_initial', '2022-05-30 10:49:39.446988'),
(19, 'users', '0001_initial', '2022-05-30 10:49:39.789717'),
(20, 'users', '0002_delete_rates', '2022-05-30 10:49:40.037040'),
(21, 'users', '0003_initial', '2022-05-30 10:49:40.376463'),
(22, 'users', '0004_unwantedwords', '2022-05-30 10:49:41.023690'),
(23, 'users', '0005_blockcontacts', '2022-05-30 10:49:41.526287'),
(24, 'users', '0006_ratescomments', '2022-05-30 10:49:41.978671'),
(25, 'users', '0007_alter_blockcontacts_date_alter_ratescomments_date', '2022-05-30 10:49:42.081521'),
(26, 'users', '0008_alter_blockcontacts_date_alter_ratescomments_date', '2022-05-30 10:49:42.130444'),
(27, 'users', '0009_tarrifs_alter_blockcontacts_date_and_more', '2022-05-30 10:49:47.038882'),
(28, 'users', '0010_rename_updat_date_tarrifs_update_date_and_more', '2022-05-30 10:49:47.223999'),
(29, 'users', '0011_alter_ratescomments_date', '2022-05-30 10:49:47.283796'),
(30, 'users', '0012_alter_ratescomments_date', '2022-05-30 10:49:47.350203'),
(31, 'users', '0013_rename_username_tarrifs_usernames_and_more', '2022-05-30 10:49:47.480299'),
(32, 'users', '0014_rename_usernames_tarrifs_username_and_more', '2022-05-30 10:49:47.722021'),
(33, 'users', '0015_tarrifs_comment_alter_ratescomments_date', '2022-05-30 10:49:48.039476'),
(34, 'users', '0016_rename_rates_projects', '2022-05-30 10:49:48.305099'),
(35, 'users', '0017_rename_description_projects_name', '2022-05-30 10:49:48.444344'),
(36, 'users', '0018_delete_projects', '2022-05-30 10:49:48.719736'),
(37, 'users', '0019_projects', '2022-05-30 10:49:49.088607'),
(38, 'users', '0020_alter_tarrifs_amount', '2022-05-30 10:49:50.233299'),
(39, 'users', '0021_alter_tarrifs_amount', '2022-05-30 10:49:51.441438'),
(40, 'users', '0022_profile', '2022-05-30 10:49:53.557880'),
(41, 'users', '0023_ratescomments_grade', '2022-05-30 10:49:53.860983'),
(42, 'users', '0024_viewuser', '2022-05-30 10:49:53.917882'),
(43, 'users', '0025_alter_profile_username', '2022-05-30 10:49:56.364868'),
(44, 'users', '0026_rename_username_profile_user', '2022-05-30 10:49:59.113786'),
(45, 'users', '0027_alter_profile_user', '2022-05-30 10:50:02.265328'),
(46, 'users', '0028_alter_profile_user', '2022-05-30 10:50:05.247234'),
(47, 'users', '0029_rename_username_ratescomments_usern', '2022-05-30 10:50:05.423485'),
(48, 'users', '0030_rename_usern_ratescomments_username', '2022-05-30 10:50:05.801225'),
(49, 'users', '0031_price_requestitem', '2022-05-30 11:36:07.724303');

-- --------------------------------------------------------

--
-- Table structure for table `django_session`
--

CREATE TABLE `django_session` (
  `session_key` varchar(40) NOT NULL,
  `session_data` longtext NOT NULL,
  `expire_date` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `django_session`
--

INSERT INTO `django_session` (`session_key`, `session_data`, `expire_date`) VALUES
('1w0ykgwryif1wfve82s74enlontyad98', '.eJxVjDsOwyAQBe9CHSFg8RpSpvcZ0PILTiKQjF1FuXtsyUXSvpl5b-ZoW4vbelrcHNmVKXb53TyFZ6oHiA-q98ZDq-sye34o_KSdTy2m1-10_w4K9bLXMuMAUVmJgDpKQPAk0WqhDRk_DkEH72HHAjMlIRCVTBn0KEUCA5Z9vrGHNnk:1nwzhT:5l_NkW5fA8YsLl3eZ5TCjGN_QkY4u2hTfaJ68a4UYWo', '2022-06-17 05:18:19.456544'),
('b3m6qm2ysvp66pu6jsxa20feqw3cte5l', '.eJxVjDsOwyAQBe9CHSFg8RpSpvcZ0PILTiKQjF1FuXtsyUXSvpl5b-ZoW4vbelrcHNmVKXb53TyFZ6oHiA-q98ZDq-sye34o_KSdTy2m1-10_w4K9bLXMuMAUVmJgDpKQPAk0WqhDRk_DkEH72HHAjMlIRCVTBn0KEUCA5Z9vrGHNnk:1nvd4f:XM4KMA9ab1OviDeZOXu5SLBFTUGQF1Red8k4TUBKISI', '2022-06-13 10:56:37.040307'),
('m17orhrdfvfm791v3tw0fcqshfsatjix', '.eJxVjEEOwiAQRe_C2hAGWqAu3XsGMjCDVA0kpV0Z765NutDtf-_9lwi4rSVsnZcwkzgLI06_W8T04LoDumO9NZlaXZc5yl2RB-3y2oifl8P9OyjYy7e2CS1QpJzJOgVsyLhowdOI3g06s2IzuAnZeO00Q0wOIzAwgx1xUuL9Af8zOF0:1nx0ux:O0-NA_GlB-9dYvMJafK4eeIkBlBMR4VDqbmVFQ0wX3Q', '2022-06-17 06:36:19.647608'),
('r8d58vncdt6m9ngcxcg8k94o5ssl04dt', '.eJxVjEEOgjAQRe_StWnaMsOIS_ecgQwzraCmTSisjHdXEha6_e-9_zIDb-s0bDUuw6zmYrw5_W4jyyPmHeid861YKXld5tHuij1otX3R-Lwe7t_BxHX61hhHYC8QnWsTJkSvLbEnCHgOyTVACE0D2AWVjrw6JWiDpyQS2BGY9wfAZTao:1nvd3j:6fOwEIqv29x9KfR-4zzHvI6dQ44oSIUxkcFfmP09lMM', '2022-06-13 10:55:39.687544'),
('tzaevcv12mgp680f26yjkl2u74fs5jta', '.eJxVjEEOgjAQRe_StWnaMsOIS_ecgQwzraCmTSisjHdXEha6_e-9_zIDb-s0bDUuw6zmYrw5_W4jyyPmHeid861YKXld5tHuij1otX3R-Lwe7t_BxHX61hhHYC8QnWsTJkSvLbEnCHgOyTVACE0D2AWVjrw6JWiDpyQS2BGY9wfAZTao:1nx0pM:JZgwbmC4zn40LXP4xSM_AdPLPwPMxN0spE2MWojAH64', '2022-06-17 06:30:32.261670');

-- --------------------------------------------------------

--
-- Table structure for table `users_blockcontacts`
--

CREATE TABLE `users_blockcontacts` (
  `id` bigint(20) NOT NULL,
  `username` varchar(25) NOT NULL,
  `word` varchar(25) NOT NULL,
  `date` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `users_price`
--

CREATE TABLE `users_price` (
  `id` bigint(20) NOT NULL,
  `description` varchar(25) NOT NULL,
  `cost` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users_price`
--

INSERT INTO `users_price` (`id`, `description`, `cost`) VALUES
(1, 'Chair', 50),
(2, 'tables', 1000),
(3, 'Keyboard', 10),
(4, 'books', 1.3),
(5, 'Monitor', 500),
(6, 'Laptop', 1000),
(7, 'power adapters', 200);

-- --------------------------------------------------------

--
-- Table structure for table `users_profile`
--

CREATE TABLE `users_profile` (
  `id` bigint(20) NOT NULL,
  `ward` varchar(2) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users_profile`
--

INSERT INTO `users_profile` (`id`, `ward`, `user_id`) VALUES
(1, '13', 1),
(2, '12', 4);

-- --------------------------------------------------------

--
-- Table structure for table `users_projects`
--

CREATE TABLE `users_projects` (
  `id` bigint(20) NOT NULL,
  `rate_number` varchar(10) NOT NULL,
  `name` varchar(200) NOT NULL,
  `price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users_projects`
--

INSERT INTO `users_projects` (`id`, `rate_number`, `name`, `price`) VALUES
(1, '2000', 'School', 12),
(2, '2001', 'Road Maintenance', 100);

-- --------------------------------------------------------

--
-- Table structure for table `users_ratescomments`
--

CREATE TABLE `users_ratescomments` (
  `id` bigint(20) NOT NULL,
  `username` varchar(25) NOT NULL,
  `rate` varchar(10) NOT NULL,
  `comment` varchar(500) NOT NULL,
  `date` datetime(6) NOT NULL,
  `grade` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users_ratescomments`
--

INSERT INTO `users_ratescomments` (`id`, `username`, `rate`, `comment`, `date`, `grade`) VALUES
(1, '04-177740W04', '1001', 'Zviri kudhura izvi', '2022-05-30 12:56:13.774651', '0'),
(2, '04-177740W04', '2000', 'toda kuvakirwa mablocks maviri ekudzidzira', '2022-05-30 15:45:56.359050', '1'),
(3, '04-177740W04', '2001', 'our road needs maintenance', '2022-05-30 15:48:31.458979', '1'),
(4, '04-177740W04', '1001', 'zvinhu zvenyu zviri kudhura', '2022-05-30 16:03:24.665412', '0'),
(7, 'Mlambo', '2000', 'Kedu kuWard 24 there is no school ', '2022-06-04 05:00:54.813312', '0'),
(8, 'Mlambo', '2000', 'maroads ashata awa', '2022-06-04 05:01:44.763544', '0');

-- --------------------------------------------------------

--
-- Table structure for table `users_requestitem`
--

CREATE TABLE `users_requestitem` (
  `id` bigint(20) NOT NULL,
  `category` varchar(25) NOT NULL,
  `description` varchar(25) NOT NULL,
  `quantity` int(11) NOT NULL,
  `status` varchar(10) NOT NULL,
  `date` datetime(6) NOT NULL,
  `username_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users_requestitem`
--

INSERT INTO `users_requestitem` (`id`, `category`, `description`, `quantity`, `status`, `date`, `username_id`) VALUES
(1, 'Furniture', '2', 20, 'Pending', '2022-05-30 13:41:41.000000', 3),
(6, 'Stationery', '4', 100, 'Pending', '2022-05-30 14:20:06.477732', 3),
(7, 'Stationery', '4', 100, 'Pending', '2022-05-30 14:21:48.063883', 3),
(8, 'Stationery', '4', 100, 'Pending', '2022-05-30 15:50:08.553710', 3);

-- --------------------------------------------------------

--
-- Table structure for table `users_tarrifs`
--

CREATE TABLE `users_tarrifs` (
  `id` bigint(20) NOT NULL,
  `name` varchar(30) NOT NULL,
  `tarrif_number` varchar(10) NOT NULL,
  `amount` double NOT NULL,
  `update_date` datetime(6) NOT NULL,
  `username` varchar(25) NOT NULL,
  `comment` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users_tarrifs`
--

INSERT INTO `users_tarrifs` (`id`, `name`, `tarrif_number`, `amount`, `update_date`, `username`, `comment`) VALUES
(1, 'General Dealer', '1001', 1000, '2022-05-30 10:54:34.000000', 'Huro', 'Price too high');

-- --------------------------------------------------------

--
-- Table structure for table `users_unwantedwords`
--

CREATE TABLE `users_unwantedwords` (
  `id` bigint(20) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users_unwantedwords`
--

INSERT INTO `users_unwantedwords` (`id`, `name`) VALUES
(1, 'fuck'),
(2, 'uri imbwa'),
(3, 'dhoti'),
(4, 'imbwa');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `auth_group`
--
ALTER TABLE `auth_group`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `auth_group_permissions`
--
ALTER TABLE `auth_group_permissions`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `auth_group_permissions_group_id_permission_id_0cd325b0_uniq` (`group_id`,`permission_id`),
  ADD KEY `auth_group_permissio_permission_id_84c5c92e_fk_auth_perm` (`permission_id`);

--
-- Indexes for table `auth_permission`
--
ALTER TABLE `auth_permission`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `auth_permission_content_type_id_codename_01ab375a_uniq` (`content_type_id`,`codename`);

--
-- Indexes for table `auth_user`
--
ALTER TABLE `auth_user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `auth_user_groups`
--
ALTER TABLE `auth_user_groups`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `auth_user_groups_user_id_group_id_94350c0c_uniq` (`user_id`,`group_id`),
  ADD KEY `auth_user_groups_group_id_97559544_fk_auth_group_id` (`group_id`);

--
-- Indexes for table `auth_user_user_permissions`
--
ALTER TABLE `auth_user_user_permissions`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `auth_user_user_permissions_user_id_permission_id_14a6b632_uniq` (`user_id`,`permission_id`),
  ADD KEY `auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm` (`permission_id`);

--
-- Indexes for table `django_admin_log`
--
ALTER TABLE `django_admin_log`
  ADD PRIMARY KEY (`id`),
  ADD KEY `django_admin_log_content_type_id_c4bce8eb_fk_django_co` (`content_type_id`),
  ADD KEY `django_admin_log_user_id_c564eba6_fk_auth_user_id` (`user_id`);

--
-- Indexes for table `django_content_type`
--
ALTER TABLE `django_content_type`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `django_content_type_app_label_model_76bd3d3b_uniq` (`app_label`,`model`);

--
-- Indexes for table `django_migrations`
--
ALTER TABLE `django_migrations`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `django_session`
--
ALTER TABLE `django_session`
  ADD PRIMARY KEY (`session_key`),
  ADD KEY `django_session_expire_date_a5c62663` (`expire_date`);

--
-- Indexes for table `users_blockcontacts`
--
ALTER TABLE `users_blockcontacts`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users_price`
--
ALTER TABLE `users_price`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users_profile`
--
ALTER TABLE `users_profile`
  ADD PRIMARY KEY (`id`),
  ADD KEY `users_profile_username_id_5fdcc277` (`user_id`);

--
-- Indexes for table `users_projects`
--
ALTER TABLE `users_projects`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users_ratescomments`
--
ALTER TABLE `users_ratescomments`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users_requestitem`
--
ALTER TABLE `users_requestitem`
  ADD PRIMARY KEY (`id`),
  ADD KEY `users_requestitem_username_id_1ae738b5_fk_auth_user_id` (`username_id`);

--
-- Indexes for table `users_tarrifs`
--
ALTER TABLE `users_tarrifs`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users_unwantedwords`
--
ALTER TABLE `users_unwantedwords`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `auth_group`
--
ALTER TABLE `auth_group`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `auth_group_permissions`
--
ALTER TABLE `auth_group_permissions`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `auth_permission`
--
ALTER TABLE `auth_permission`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT for table `auth_user`
--
ALTER TABLE `auth_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `auth_user_groups`
--
ALTER TABLE `auth_user_groups`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `auth_user_user_permissions`
--
ALTER TABLE `auth_user_user_permissions`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `django_admin_log`
--
ALTER TABLE `django_admin_log`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `django_content_type`
--
ALTER TABLE `django_content_type`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `django_migrations`
--
ALTER TABLE `django_migrations`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT for table `users_blockcontacts`
--
ALTER TABLE `users_blockcontacts`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `users_price`
--
ALTER TABLE `users_price`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `users_profile`
--
ALTER TABLE `users_profile`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `users_projects`
--
ALTER TABLE `users_projects`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `users_ratescomments`
--
ALTER TABLE `users_ratescomments`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users_requestitem`
--
ALTER TABLE `users_requestitem`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users_tarrifs`
--
ALTER TABLE `users_tarrifs`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `users_unwantedwords`
--
ALTER TABLE `users_unwantedwords`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `auth_group_permissions`
--
ALTER TABLE `auth_group_permissions`
  ADD CONSTRAINT `auth_group_permissio_permission_id_84c5c92e_fk_auth_perm` FOREIGN KEY (`permission_id`) REFERENCES `auth_permission` (`id`),
  ADD CONSTRAINT `auth_group_permissions_group_id_b120cbf9_fk_auth_group_id` FOREIGN KEY (`group_id`) REFERENCES `auth_group` (`id`);

--
-- Constraints for table `auth_permission`
--
ALTER TABLE `auth_permission`
  ADD CONSTRAINT `auth_permission_content_type_id_2f476e4b_fk_django_co` FOREIGN KEY (`content_type_id`) REFERENCES `django_content_type` (`id`);

--
-- Constraints for table `auth_user_groups`
--
ALTER TABLE `auth_user_groups`
  ADD CONSTRAINT `auth_user_groups_group_id_97559544_fk_auth_group_id` FOREIGN KEY (`group_id`) REFERENCES `auth_group` (`id`),
  ADD CONSTRAINT `auth_user_groups_user_id_6a12ed8b_fk_auth_user_id` FOREIGN KEY (`user_id`) REFERENCES `auth_user` (`id`);

--
-- Constraints for table `auth_user_user_permissions`
--
ALTER TABLE `auth_user_user_permissions`
  ADD CONSTRAINT `auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm` FOREIGN KEY (`permission_id`) REFERENCES `auth_permission` (`id`),
  ADD CONSTRAINT `auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id` FOREIGN KEY (`user_id`) REFERENCES `auth_user` (`id`);

--
-- Constraints for table `django_admin_log`
--
ALTER TABLE `django_admin_log`
  ADD CONSTRAINT `django_admin_log_content_type_id_c4bce8eb_fk_django_co` FOREIGN KEY (`content_type_id`) REFERENCES `django_content_type` (`id`),
  ADD CONSTRAINT `django_admin_log_user_id_c564eba6_fk_auth_user_id` FOREIGN KEY (`user_id`) REFERENCES `auth_user` (`id`);

--
-- Constraints for table `users_profile`
--
ALTER TABLE `users_profile`
  ADD CONSTRAINT `users_profile_user_id_2112e78d_fk_auth_user_id` FOREIGN KEY (`user_id`) REFERENCES `auth_user` (`id`);

--
-- Constraints for table `users_requestitem`
--
ALTER TABLE `users_requestitem`
  ADD CONSTRAINT `users_requestitem_username_id_1ae738b5_fk_auth_user_id` FOREIGN KEY (`username_id`) REFERENCES `auth_user` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
