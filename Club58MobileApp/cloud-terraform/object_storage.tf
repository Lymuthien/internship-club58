resource "yandex_storage_bucket" "media1" {
  access_key       = yandex_iam_service_account_static_access_key.sa-terraform-key.access_key
  acl              = "public-read"
  bucket           = "club58-mobile-app-media"
  force_destroy    = false
  secret_key       = yandex_iam_service_account_static_access_key.sa-terraform-key.secret_key
}

